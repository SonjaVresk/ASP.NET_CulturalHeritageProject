using AutoMapper;

namespace CulturalHeritageWebApp.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<CulturalHeritageBL.BLModels.BLHeritage, ViewModels.VMHeritage>();
            CreateMap<CulturalHeritageBL.BLModels.BLAgeCategory, ViewModels.VMAgeCategory>();
            CreateMap<CulturalHeritageBL.BLModels.BLHeritageCategory, ViewModels.VMHeritageCategory>();
            CreateMap<CulturalHeritageBL.BLModels.BLExhibition, ViewModels.VMExhibition>();
            CreateMap<CulturalHeritageBL.BLModels.BLPhotography, ViewModels.VMPhotography>();
            CreateMap<CulturalHeritageBL.BLModels.BLVideo, ViewModels.VMVideo>();

            CreateMap<ViewModels.VMHeritage, CulturalHeritageBL.BLModels.BLHeritage>();
            CreateMap<ViewModels.VMAgeCategory, CulturalHeritageBL.BLModels.BLAgeCategory>();
            CreateMap<ViewModels.VMHeritageCategory, CulturalHeritageBL.BLModels.BLHeritageCategory>();
            CreateMap<ViewModels.VMExhibition, CulturalHeritageBL.BLModels.BLExhibition>();
            CreateMap<ViewModels.VMPhotography, CulturalHeritageBL.BLModels.BLPhotography>();
            CreateMap<ViewModels.VMVideo, CulturalHeritageBL.BLModels.BLVideo>();
        }
    }
}
