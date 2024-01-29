using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMVideo
    {
        public VMVideo()
        {
            ExhibitionVideos = new List<BLExhibitionVideo>();
        }

        public int IDVideo { get; set; }
        public int? HeritageId { get; set; }
        public string? VideoPath { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public VMHeritage? Heritage { get; set; }
        public BLUser? User { get; set; }
        public List<BLExhibitionVideo> ExhibitionVideos { get; set; }
    }
}
