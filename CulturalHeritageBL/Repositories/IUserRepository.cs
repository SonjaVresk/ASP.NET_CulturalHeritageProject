using CulturalHeritageBL.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<BLUser> GetAll();
    }
}
