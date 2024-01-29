using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLExhibitionVideo
    {
        public int IDExhibitionVideo { get; set; }
        public int? ExhibitionId { get; set; }
        public int? VideoId { get; set; }

        public BLExhibition? Exhibition { get; set; }
        public BLVideo? Video { get; set; }
    }
}
