using AutoMapper;
using CulturalHeritageBL.BLModels;
using CulturalHeritageBL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Repositories
{
    public class HeritageCategoryRepository :IHeritageCategoryRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;

        public HeritageCategoryRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<BLHeritageCategory> GetAllHeritageCategories()
        {
            var heritageCategories = _dbContext.AgeCategories;

            var blHeritageCategories = _mapper.Map<IEnumerable<BLHeritageCategory>>(heritageCategories);

            return blHeritageCategories;
        }

        public int GetHeritageCategoryID(string name)
        {
            var heritageCategory = _dbContext.HeritageCategories
                .Include(a => a.Heritages)
                .FirstOrDefault(a => a.Name == name);

            var heritageCategoryID = heritageCategory.IDHeritageCategory;

            return heritageCategoryID;
        }
    }
}
