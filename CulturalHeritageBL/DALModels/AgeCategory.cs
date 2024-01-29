using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class AgeCategory
    {
        public AgeCategory()
        {
            Heritages = new HashSet<Heritage>();
        }

        public int IDAgeCategory { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Heritage> Heritages { get; set; }
    }
}
