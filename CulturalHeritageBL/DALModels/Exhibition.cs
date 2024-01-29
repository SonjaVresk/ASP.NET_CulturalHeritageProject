using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class Exhibition
    {
        public Exhibition()
        {
            ExhibitionPhotographies = new HashSet<ExhibitionPhotography>();
            ExhibitionVideos = new HashSet<ExhibitionVideo>();
        }

        public int IDExhibition { get; set; }
        public int? HeritageId { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public virtual Heritage? Heritage { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<ExhibitionPhotography> ExhibitionPhotographies { get; set; }
        public virtual ICollection<ExhibitionVideo> ExhibitionVideos { get; set; }
    }
}
