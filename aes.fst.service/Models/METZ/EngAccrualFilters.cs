using System;
using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualFilters : BaseModel
    {
        public long UserId { get; set; }

        public long CustomerId { get; set; }

        public long WellId { get; set; }

        public string FieldServiceTicketNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<long> WellIds { get; set; }

        public DateTime StartDate { get; set; }

    }
}
