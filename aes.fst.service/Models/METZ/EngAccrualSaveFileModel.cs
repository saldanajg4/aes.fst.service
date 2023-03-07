using aes.fst.service.Models;
using Microsoft.AspNetCore.Http;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualSaveFileModel : BaseModel
    {
        public long WellId { get; set; }

        public string WellName { get; set; }

        public string CustomerName { get; set; }

        public string FieldServiceTicket { get; set; }

        public long CreatedById { get; set; }

        public string CreatedBy { get; set; }

    }
}
