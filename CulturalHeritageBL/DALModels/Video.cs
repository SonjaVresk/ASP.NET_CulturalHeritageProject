using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class Video
    {
        public Video()
        {
            ExhibitionVideos = new HashSet<ExhibitionVideo>();
        }

        public int IDVideo { get; set; }
        public int? HeritageId { get; set; }
        public string? VideoPath { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public virtual Heritage? Heritage { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<ExhibitionVideo> ExhibitionVideos { get; set; }
    }
}
