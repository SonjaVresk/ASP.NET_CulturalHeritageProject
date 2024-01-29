using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLPhotography
    {
        public BLPhotography()
        {
            ExhibitionPhotographies = new List<BLExhibitionPhotography>();
        }

        public int IDPhotography { get; set; }
        public int? HeritageId { get; set; }
        public string? PicturePath { get; set; }
        public string? Description { get; set; }

        public BLHeritage? Heritage { get; set; }
        public List<BLExhibitionPhotography> ExhibitionPhotographies { get; set; }
    }
}
