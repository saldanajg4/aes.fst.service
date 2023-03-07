using System;
using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualStatusPageModel : BaseModel
    {
        public string Id { get; set; }

        public long UserId { get; set; }

        public long WellId { get; set; }

        public int StatusId { get; set; }        

        public string CustomerName { get; set; }

        public long CustomerId { get; set; }

        public string WellName { get; set; }

        public byte? DivisionId { get; set; }

        public string DivisionName { get; set; }

        public string CountyName { get; set; }

        public string RigName { get; set; }

        public string FieldServiceTicket { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MudEngineerModel MudEngineer { get; set; }

        public decimal ConsultRate { get; set; }

        public decimal TravelRate { get; set; }

        public decimal DiemRate { get; set; }

        public decimal TrainingRate { get; set; }

        public decimal DriveByRate { get; set; }

        public string Afe { get; set; }

        public string State { get; set; }

        public List<EngAccrualDayInfoModel> Days { get; set; }        

        public decimal MiscExpense { get; set; }

        public DateTime CurrentDate { get; set; }

        public int NumberOfWorkingDays { get; set; }

        public int NumberOfTravelingDays { get; set; }

        public decimal TravelingMiles { get; set; }

        public decimal TimeSheetTotal { get; set; }

        public decimal PricePerMile { get; set; }

        public List<ReportModel> Reports { get; set; }

        public List<EngAccrualDayInfoModel> AddedDays { get; set; }

        public List<EngAccrualMiscExpenseModel> MiscExpenses { get; set; }

        public List<FstCommentModel> Comments { get; set; }

        public List<FstAction> FstActions { get; set; }

        public string MudEngineerName { get; set; }

        public string Approver { get; set; }

        public string StatusName { get; set; }

        public string FileName { get; set; }        

        public PdfFstTypeModel RequestPdfTypeModel { get; set; }

        public string RevisedBy { get; set; }

        public int PreviousStatus { get; set; }

        public string TravelDates { get; set; }

    }
}
