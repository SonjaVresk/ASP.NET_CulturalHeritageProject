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
    public class HeritageRepository : IHeritageRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;

        public HeritageRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IEnumerable<BLHeritage> GetAllHeritage()
        {
            var heritage = _dbContext.Heritages
                .Include(a => a.AgeCategory)
                .Include(a => a.HeritageCategory)
                .Include(a => a.Photographies)
                .Include(a => a.Videos);

            var blHeritage = _mapper.Map<IEnumerable<BLHeritage>>(heritage);

            return blHeritage;
        }

        public BLHeritage GetHeritage(int id)
        {
            
            var heritage = _dbContext.Heritages
                .Include(a => a.AgeCategory)
                .Include(a => a.HeritageCategory)
                .Include(a => a.Photographies)
                .Include(a => a.Videos)
                .FirstOrDefault(a => a.IDHeritage == id);

            var blHeritage = _mapper.Map<BLHeritage>(heritage);

            return blHeritage;
        }

        public void AddHeritage(Heritage heritage)
        {
            _dbContext.Heritages.Add(heritage);
            _dbContext.SaveChanges();
        }

        public void DeleteHeritage(Heritage heritage)
        {
            _dbContext.Heritages.Remove(heritage);
            _dbContext.SaveChanges();
        }
    }
}
