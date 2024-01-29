using CulturalHeritageBL.BLModels;

namespace CulturalHeritageWebApp.ViewModels
{
    public class VMRole
    {
        public VMRole()
        {
            Users = new List<VMUser>();
        }

        public int IDRole { get; set; }
        public string Name { get; set; } = null!;

        public List<VMUser> Users { get; set; }
    }
}
