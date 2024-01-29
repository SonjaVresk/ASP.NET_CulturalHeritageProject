using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLUser
    {
        public BLUser()
        {
            Exhibitions = new List<BLExhibition>();
            Videos = new List<BLVideo>();
        }

        public int IDUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? RoleId { get; set; }

        public BLRole? Role { get; set; }
        public List<BLExhibition> Exhibitions { get; set; }
        public List<BLVideo> Videos { get; set; }
    }
}
