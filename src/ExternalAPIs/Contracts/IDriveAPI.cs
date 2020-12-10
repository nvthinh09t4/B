using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAPIs.Contracts
{
    public interface IDriveAPI
    {
        Task<bool> UploadFile(byte[] byteArray);
    }
}
