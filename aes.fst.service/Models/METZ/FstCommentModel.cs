using System;

namespace aes.fst.service.Models.METZ
{
    public class FstCommentModel : BaseModel
    {
        public string PostedBy { get; set; }

        public DateTime PostedOn { get; set; }

        public string Comment { get; set; }

    }
}
