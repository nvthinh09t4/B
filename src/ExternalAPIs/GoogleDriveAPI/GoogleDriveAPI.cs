using ExternalAPIs.Contracts;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Hosting.Internal;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Hosting;
using Google.Apis.Services;

namespace ExternalAPIs.GoogleDriveAPI
{
    public class GoogleDriveAPI : IGoogleDriveAPI
    {
        //add scope
        public static string[] Scopes = { Google.Apis.Drive.v3.DriveService.Scope.Drive };
        private IHostingEnvironment _env;

        public GoogleDriveAPI(IHostingEnvironment env)
        {
            _env = env;
        }

        public DriveService GetService()
        {
            UserCredential credential;
            //Root Folder of project
            var CSPath = _env.ContentRootPath;
            using (var stream = new FileStream(Path.Combine(CSPath, "googleDriveCredential.json"), FileMode.Open, FileAccess.Read))
            {
                String FolderPath = _env.ContentRootPath;
                String FilePath = Path.Combine(FolderPath, "DriveServiceCredentials.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(FilePath, true)).Result;
            }
            //create Drive API service.
            DriveService service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer() {
                HttpClientInitializer = credential,
                ApplicationName = "ReadPDF",
            });
            return service;
        }
        public Task<bool> UploadFile(byte[] byteArray)
        {
            var service = GetService();
            throw new NotImplementedException();
        }
    }
}
