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
    public class AgeCategoryRepository : IAgeCategoryRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;

        public AgeCategoryRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<BLAgeCategory> GetAllAgeCategories()
        {
            var ageCategories = _dbContext.AgeCategories;

            var blAgeCategories = _mapper.Map<IEnumerable<BLAgeCategory>>(ageCategories);

            return blAgeCategories;
        }

        public BLAgeCategory GetAgeCategory(int id)
        {
            var ageCategory = _dbContext.AgeCategories
                .Include(a => a.Heritages)
                .FirstOrDefault(a => a.IDAgeCategory == id);

            var blAgeCategory = _mapper.Map<BLAgeCategory>(ageCategory);

            return blAgeCategory;
        }
    }
}
