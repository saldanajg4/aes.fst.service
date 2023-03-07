using System;
using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualGeneratePdfModel : BaseModel
    {
        public long wellId { get; set; }

        public long UserId { get; set; }

        public string MeName { get; set; }

        public string FieldServiceTicket { get; set; }

        public string OperatorName { get; set; }

        public string County { get; set; }

        public string WellName { get; set; }

        public string RigName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<EngAccrualDayInfoModel> ConsultingDays { get; set; }

        public int NumberOfWorkingDays { get; set; }

        public int NumberOfTravelingDays { get; set; }

        public decimal WorkingRate { get; set; }

        public decimal TravelingRate { get; set; }

        public decimal TravelingMiles { get; set; }

        public decimal PricePerMile { get; set; }

        public decimal PricePerLivingExpense { get; set; }

        public decimal MiscExpense { get; set; }

        public decimal TimeSheetTotal { get; set; }

        public string Afe { get; set; }

        public string State { get; set; }

        public DateTime CurrentDate { get; set; }

    }
}
