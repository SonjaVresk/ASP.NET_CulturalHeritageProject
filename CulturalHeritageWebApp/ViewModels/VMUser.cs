using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMUser
    {
        public VMUser()
        {
            Exhibitions = new List<VMExhibition>();
            Videos = new List<VMVideo>();
        }

        public int IDUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? RoleId { get; set; }

        public VMRole? Role { get; set; }
        public List<VMExhibition> Exhibitions { get; set; }
        public List<VMVideo> Videos { get; set; }
    }
}
