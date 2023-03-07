using System;
using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualHeaderInfoModel : BaseModel
    {
        public int ProjectID { get; set; }

        public long WellId { get; set; }

        public string WellName { get; set; }

        public long UserId { get; set; }

        public MudEngineerModel MudEngineer { get; set; }       

        public string RigName { get; set; }

        public string County { get; set; }

        public List<TimeSheetModel> TimeSheets { get; set; }

        public decimal ConsultRate { get; set; }

        public decimal TravelRate { get; set; }

        public decimal DiemRate { get; set; }

        public decimal TrainingRate { get; set; }

        public decimal DriveByRate { get; set; }

        public string Afe { get; set; }

        public string State { get; set; }

        public DateTime CurrentDate { get; set; }

        public string CustomerName { get; set; }

        public List<ReportModel> Reports { get; set; }

        public byte? DivisionId { get; set; }

        public string DivisionName { get; set; }

        public bool AreFstAndRfdListsEqual { get; set; }

    }
}
