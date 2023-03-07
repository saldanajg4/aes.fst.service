using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aes.fst.service.Models
{
    public enum RequestStatus
    {
        Pending = 0,
        Success = 1,
        Error = 2,
        AlreadyProcessed = 3,
        NotFound = 4
    }

}
