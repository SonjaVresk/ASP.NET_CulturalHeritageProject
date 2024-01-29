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
    public class PhotographyRepository : IPhotographyRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;

        public PhotographyRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<BLPhotography> GetAllPhotographies()
        {
            var photos = _dbContext.Photographies;

            var blPhotos = _mapper.Map<IEnumerable<BLPhotography>>(photos);

            return blPhotos;
        }

        public BLPhotography GetPhotography(int id)
        {
            var photo = _dbContext.Photographies
                .Include(a => a.Heritage)
                .FirstOrDefault(a => a.IDPhotography == id);

            var bLPhotography = _mapper.Map<BLPhotography>(photo);

            return bLPhotography;
        }

    }
}
