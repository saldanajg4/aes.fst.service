using System;

namespace aes.fst.service.Models.METZ
{
    public class ReportModel : BaseModel
    {

        public int ProjectId { get; set; }

        public long ReportId { get; set; }


        public Int16 IntervalId { get; set; }

        public int? FormationId { get; set; }

        public DateTime ReportDate { get; set; }

        public Int16 ReportNumber { get; set; }

        public string Interval { get; set; }

        public decimal ReportDepthMD { get; set; }

        public decimal ReportDepthTVD { get; set; }

        public decimal ReportDepthBit { get; set; }

        public decimal ReportAngle { get; set; }

        public Single? CirculationGPM { get; set; }

        public Single? CirculationPSIActual { get; set; }

        public Single? CirculationPSICalculated { get; set; }

        public string CurrentActivty { get; set; }

        public string ActivityComments { get; set; }

        public string RemarksOne { get; set; }

        public string RemarksTwo { get; set; }

        public string RemarksThree { get; set; }

        public string RemarksFour { get; set; }

        public string RemarksFive { get; set; }

        public string CompanyPersonnel { get; set; }

        public string ContractPersonnel { get; set; }

        public decimal? CumulativeCostAES { get; set; }

        public decimal? CumulativeCostAll { get; set; }

        public decimal? DailyPrice { get; set; }

        public decimal? DailyPriceAesOnly { get; set; }

        public decimal? DaysFootage { get; set; }

        public MudEngineerModel EngineerOne { get; set; }

        public MudEngineerModel EngineerTwo { get; set; }


    }
}
