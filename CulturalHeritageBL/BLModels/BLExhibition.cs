using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLExhibition
    {
        public BLExhibition()
        {
            ExhibitionPhotographies = new List<BLExhibitionPhotography>();
            ExhibitionVideos = new List<BLExhibitionVideo>();
        }

        public int IDExhibition { get; set; }
        public int? HeritageId { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public BLHeritage? Heritage { get; set; }
        public BLUser? User { get; set; }
        public List<BLExhibitionPhotography> ExhibitionPhotographies { get; set; }
        public List<BLExhibitionVideo> ExhibitionVideos { get; set; }
    }
}
