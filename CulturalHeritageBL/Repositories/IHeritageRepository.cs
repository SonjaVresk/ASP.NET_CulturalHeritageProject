using CulturalHeritageBL.BLModels;
using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Repositories
{
    public interface IHeritageRepository
    {
        IEnumerable<BLHeritage> GetAllHeritage();

        BLHeritage GetHeritage(int id);

        void AddHeritage(Heritage heritage);

        void DeleteHeritage(Heritage heritage);
    }
}
