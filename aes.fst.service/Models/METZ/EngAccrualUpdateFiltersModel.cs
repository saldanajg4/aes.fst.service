using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualUpdateFiltersModel : BaseModel
    {

        public int WellId;

        public long UserId;

        public List<EngAccrualDayInfoModel> ConsultingDays;

        public string OperatorName { get; set; }

        public decimal MiscExpense { get; set; }       

    }
}
