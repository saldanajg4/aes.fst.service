using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aes.fst.service.Models
{
    public class BaseModel
    {
        public int RequestId { get; set; }

        public string RequestMessage { get; set; }

        public bool IsValid { get; private set; }

        //public string ModifiedById { get; set; }

        public void SetError(string errorMessage)
        {
            this.RequestId = (int)RequestStatus.Error;
            this.RequestMessage = errorMessage;
            this.IsValid = false;
        }

        public void SetError(bool isValid, string invalidReason)
        {
            this.IsValid = isValid;
            this.RequestId = (int)RequestStatus.Error;
            this.RequestMessage = invalidReason;
        }

        public void SetSuccess(string message)
        {
            this.RequestId = (int)RequestStatus.Success;
            this.RequestMessage = message;
            this.IsValid = true;
        }
    }
}
