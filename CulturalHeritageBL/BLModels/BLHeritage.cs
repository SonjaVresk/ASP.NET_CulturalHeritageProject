using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLHeritage
    {
        public BLHeritage()
        {
            Exhibitions = new List<BLExhibition>();
            Photographies = new List<BLPhotography>();
            Videos = new List<BLVideo>();
        }

        public int IDHeritage { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? HeritageCategoryId { get; set; }
        public int? AgeCategoryId { get; set; }

        public BLAgeCategory? AgeCategory { get; set; }
        public BLHeritageCategory? HeritageCategory { get; set; }
        public List<BLExhibition> Exhibitions { get; set; }
        public List<BLPhotography> Photographies { get; set; }
        public List<BLVideo> Videos { get; set; }

    }
}
