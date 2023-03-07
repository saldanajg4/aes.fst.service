using System;
using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class TimeSheetModel : BaseModel
    {

        public int ProjectID { get; set; }


        public int MudEngineerID { get; set; }


        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }


        public byte? DayCount { get; set; }


        public string FieldServiceTicketNo { get; set; }


        public byte? ServiceTypeID { get; set; }

        public bool IsCompleted { get; set; }

        public List<EngAccrualDayInfoModel> Days { get; set; }

        public string OperatorName { get; set; }

        public decimal MiscExpense { get; set; }

    }
}
