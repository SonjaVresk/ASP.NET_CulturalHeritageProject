using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMExhibition
    {
        public VMExhibition()
        {
            ExhibitionPhotographies = new List<BLExhibitionPhotography>();
            ExhibitionVideos = new List<BLExhibitionVideo>();
        }

        public int IDExhibition { get; set; }
        public int? HeritageId { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public VMHeritage? Heritage { get; set; }
        public BLUser? User { get; set; }
        public List<BLExhibitionPhotography> ExhibitionPhotographies { get; set; }
        public List<BLExhibitionVideo> ExhibitionVideos { get; set; }
    }
}
