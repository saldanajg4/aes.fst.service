using System.Collections.Generic;

namespace aes.fst.service.Models.METZ
{
    public class FstRegionModel : BaseModel
    {
        public long RegionId { get; set; }

        public string Name { get; set; }

        public List<EngAdminModel> EngAdminList { get; set; }

    }
}
