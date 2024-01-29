using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class Photography
    {
        public Photography()
        {
            ExhibitionPhotographies = new HashSet<ExhibitionPhotography>();
        }

        public int IDPhotography { get; set; }
        public int? HeritageId { get; set; }
        public string? PicturePath { get; set; }
        public string? Description { get; set; }

        public virtual Heritage? Heritage { get; set; }
        public virtual ICollection<ExhibitionPhotography> ExhibitionPhotographies { get; set; }
    }
}
