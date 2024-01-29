using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLAgeCategory
    {
        public BLAgeCategory()
        {
            Heritages = new List<BLHeritage>();
        }

        public int IDAgeCategory { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public List<BLHeritage> Heritages { get; set; }
    }
}
