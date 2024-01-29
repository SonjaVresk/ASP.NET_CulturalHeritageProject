using AutoMapper;
using CulturalHeritageBL.BLModels;
using CulturalHeritageBL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CulturalHeritageContext _dbContext;
        private readonly IMapper _mapper;
        public UserRepository(CulturalHeritageContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IEnumerable<BLUser> GetAll()
        {
            var users = _dbContext.Users;

            var blUsers = _mapper.Map<IEnumerable<BLUser>>(users);

            return blUsers;
        }
    }
}
