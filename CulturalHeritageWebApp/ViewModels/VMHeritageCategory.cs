using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMHeritageCategory
    {
        public VMHeritageCategory()
        {
            Heritages = new List<VMHeritage>();
        }

        public int IDHeritageCategory { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public List<VMHeritage> Heritages { get; set; }
    }
}
