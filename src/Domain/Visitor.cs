using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Visitor : BaseEntity
    {
        public string VisitorId { get; set; }
        public string IPAddress { get; set; }
        public string Url { get; set; }
        public string Cookie { get; set; }
        public string QueryString { get; set; }
        public string Query { get; set; }
        public string RouteValue { get; set; }
        public string Body { get; set; }
        public string Username { get; set; }
    }
}
