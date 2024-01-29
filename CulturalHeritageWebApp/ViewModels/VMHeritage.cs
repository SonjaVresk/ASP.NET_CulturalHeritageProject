using CulturalHeritageBL.BLModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMHeritage
    {
        public VMHeritage()
        {
            Exhibitions = new List<VMExhibition>();
            Photographies = new List<VMPhotography>();
            Videos = new List<VMVideo>();
        }

        public int IDHeritage { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? AgeCategoryID { get; set; }
        public int? HeritageCategoryID { get; set; }

        public VMAgeCategory? AgeCategory { get; set; }
        public VMHeritageCategory? HeritageCategory { get; set; }
        public List<VMExhibition> Exhibitions { get; set; }
        public List<VMPhotography> Photographies { get; set; }
        public List<VMVideo> Videos { get; set; }

        public IEnumerable<SelectListItem> AgeCategoryList { get; set; }

    }
}
