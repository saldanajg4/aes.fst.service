using System;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualDayInfoModel : BaseModel
    {
        public long Id { get; set; }

        public DateTime ConsultingDate { get; set; }

        public int Type { get; set; }

        public string? TypeName { get; set; }

        public decimal PricePerLivingExpense { get; set; }

        public decimal Miles { get; set; }

        public decimal Rate { get; set; }

        public long? ReportId { get; set; }

        public string Comment { get; set; }

        public bool Active { get; set; }

        public string MiscDetail { get; set; }

    }
}
