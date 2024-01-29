using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class ExhibitionPhotography
    {
        public int IDExhibitionPhoto { get; set; }
        public int? ExhibitionId { get; set; }
        public int? PhotographyId { get; set; }

        public virtual Exhibition? Exhibition { get; set; }
        public virtual Photography? Photography { get; set; }
    }
}
