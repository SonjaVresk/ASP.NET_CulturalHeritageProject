using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class Heritage
    {
        public Heritage()
        {
            Exhibitions = new HashSet<Exhibition>();
            Photographies = new HashSet<Photography>();
            Videos = new HashSet<Video>();
        }

        public int IDHeritage { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? HeritageCategoryId { get; set; }
        public int? AgeCategoryId { get; set; }

        public virtual AgeCategory? AgeCategory { get; set; }
        public virtual HeritageCategory? HeritageCategory { get; set; }
        public virtual ICollection<Exhibition> Exhibitions { get; set; }
        public virtual ICollection<Photography> Photographies { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
