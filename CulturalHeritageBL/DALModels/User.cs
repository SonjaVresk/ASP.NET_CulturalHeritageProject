using System;
using System.Collections.Generic;

namespace CulturalHeritageBL.DALModels
{
    public partial class User
    {
        public User()
        {
            Exhibitions = new HashSet<Exhibition>();
            Videos = new HashSet<Video>();
        }

        public int IDUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Exhibition> Exhibitions { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
