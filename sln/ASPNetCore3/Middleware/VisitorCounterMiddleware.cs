using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCore3.Middleware
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public VisitorCounterMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context, IVisitorRepository visitorRepository, UserManager<ApplicationUser> _userManager)
        {
            string visitorId = context.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                //don the necessary staffs here to save the count by one
                visitorId = Guid.NewGuid().ToString();

                context.Response.Cookies.Append("VisitorId", visitorId, new CookieOptions() {
                    Path = "/",
                    HttpOnly = true,
                    Secure = false,
                });
            }

            var currentUser = await _userManager.GetUserAsync(context.Request.HttpContext.User);

            await visitorRepository.CreateAsync(new Domain.Visitor {
                VisitorId = visitorId,
                Cookie = JsonConvert.SerializeObject(context.Request.Cookies),
                IPAddress = context.Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString(),
                Url = (context.Request.HttpContext.Request.Host.ToString() + context.Request.HttpContext.Request.Path).Replace("//", ""),
                Query = JsonConvert.SerializeObject(context.Request.HttpContext.Request.Query),
                QueryString = context.Request.HttpContext.Request.QueryString.ToUriComponent(),
                RouteValue = JsonConvert.SerializeObject(context.Request.HttpContext.Request.RouteValues),
                Username = currentUser != null ? currentUser.UserName : "anonymous"
            }); ;

            await _requestDelegate(context);
        }
    }
}
