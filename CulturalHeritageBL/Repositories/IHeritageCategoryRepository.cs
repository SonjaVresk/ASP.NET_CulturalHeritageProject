using CulturalHeritageBL.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Repositories
{
    public interface IHeritageCategoryRepository
    {
        IEnumerable<BLHeritageCategory> GetAllHeritageCategories();
        int GetHeritageCategoryID(string name);
    }
}
