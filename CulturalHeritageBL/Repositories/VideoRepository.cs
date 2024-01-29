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
    public class VideoRepository : IVideoRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;

        public VideoRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<BLVideo> GetAllVideos()
        {
            var videos = _dbContext.Videos;

            var blVideos = _mapper.Map<IEnumerable<BLVideo>>(videos);

            return blVideos;
        }

        public BLVideo GetVideo(int id)
        {
            var video = _dbContext.Videos
                .Include(a => a.Heritage)
                .FirstOrDefault(a => a.IDVideo == id);

            var bLVideo = _mapper.Map<BLVideo>(video);

            return bLVideo;
        }
    }
}
