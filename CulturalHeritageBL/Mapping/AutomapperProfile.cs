using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalHeritageBL.Mapping
{
    public class AutomapperProfile : Profile
    {

        public AutomapperProfile()
        {
            CreateMap<DALModels.Heritage, BLModels.BLHeritage>();
            CreateMap<DALModels.AgeCategory, BLModels.BLAgeCategory>();
            CreateMap<DALModels.HeritageCategory, BLModels.BLHeritageCategory>();
            CreateMap<DALModels.Exhibition, BLModels.BLExhibition>();
            CreateMap<DALModels.ExhibitionPhotography, BLModels.BLExhibitionPhotography>();
            CreateMap<DALModels.ExhibitionVideo, BLModels.BLExhibitionVideo>();
            CreateMap<DALModels.Photography, BLModels.BLPhotography>();
            CreateMap<DALModels.Role, BLModels.BLRole>();
            CreateMap<DALModels.User, BLModels.BLUser>();
            CreateMap<DALModels.Video, BLModels.BLVideo>();

            CreateMap<BLModels.BLHeritage, DALModels.Heritage>();
            CreateMap<BLModels.BLAgeCategory, DALModels.AgeCategory>();
            CreateMap<BLModels.BLHeritageCategory, DALModels.HeritageCategory>();
            CreateMap<BLModels.BLExhibition, DALModels.Exhibition>();
            CreateMap<BLModels.BLExhibitionPhotography, DALModels.ExhibitionPhotography>();
            CreateMap<BLModels.BLExhibitionVideo, DALModels.ExhibitionVideo>();
            CreateMap<BLModels.BLPhotography, DALModels.Photography>();
            CreateMap<BLModels.BLRole, DALModels.Role>();
            CreateMap<BLModels.BLUser , DALModels.User>();
            CreateMap<BLModels.BLVideo, DALModels.Video>();
        }
    }
}
