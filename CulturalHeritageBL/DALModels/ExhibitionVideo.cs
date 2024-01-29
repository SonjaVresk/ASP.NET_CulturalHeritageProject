using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class ExhibitionVideo
    {
        public int IDExhibitionVideo { get; set; }
        public int? ExhibitionId { get; set; }
        public int? VideoId { get; set; }

        public virtual Exhibition? Exhibition { get; set; }
        public virtual Video? Video { get; set; }
    }
}
