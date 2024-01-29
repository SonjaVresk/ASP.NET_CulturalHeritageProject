using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMAgeCategory
    {
        public VMAgeCategory()
        {
            Heritages = new List<VMHeritage>();
        }

        public int IDAgeCategory { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public List<VMHeritage> Heritages { get; set; }
    }
}
