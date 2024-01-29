using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMPhotography
    {
        public VMPhotography()
        {
            ExhibitionPhotographies = new List<BLExhibitionPhotography>();
        }

        public int IDPhotography { get; set; }
        public int? HeritageId { get; set; }
        public string? PicturePath { get; set; }
        public string? Description { get; set; }

        public VMHeritage? Heritage { get; set; }
        public List<BLExhibitionPhotography> ExhibitionPhotographies { get; set; }
    }
}
