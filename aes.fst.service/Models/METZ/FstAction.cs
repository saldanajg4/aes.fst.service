using System;

namespace aes.fst.service.Models.METZ
{
    public class FstAction : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public FstCommentModel FstComment { get; set; }

    }
}
