using ExternalAPIs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAPIs.GoogleDriveAPI
{
    public class GoogleDriveAPI : IGoogleDriveAPI
    {
        public Task<bool> UploadFile(byte[] byteArray)
        {
            throw new NotImplementedException();
        }
    }
}
