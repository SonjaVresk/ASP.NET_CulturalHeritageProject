using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.BLModels
{
    public class BLRole
    {
        public BLRole()
        {
            Users = new List<BLUser>();
        }

        public int IDRole { get; set; }
        public string Name { get; set; } = null!;

        public List<BLUser> Users { get; set; }
    }
}

