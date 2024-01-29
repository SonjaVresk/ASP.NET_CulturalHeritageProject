using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class HeritageCategory
    {
        public HeritageCategory()
        {
            Heritages = new HashSet<Heritage>();
        }

        public int IDHeritageCategory { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Heritage> Heritages { get; set; }
    }
}
