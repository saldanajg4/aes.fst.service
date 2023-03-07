using System;

namespace aes.fst.service.Models.METZ
{
    public class EngAccrualMiscExpenseModel : BaseModel
    {
        public int Type { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Comment { get; set; }

    }
}
