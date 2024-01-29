using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLExhibitionPhotography
    {
        public int IDExhibitionPhoto { get; set; }
        public int? ExhibitionId { get; set; }
        public int? PhotographyId { get; set; }

        public BLExhibition? Exhibition { get; set; }
        public BLPhotography? Photography { get; set; }
    }
}
