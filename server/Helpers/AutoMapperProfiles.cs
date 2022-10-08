using Server.Entities;
using AutoMapper;
using Server.DtoModels;

namespace Server.Helpers
{
    public class AutoMapperProfiles : Profile
    {
             public AutoMapperProfiles()
            {
                CreateMap<AppUser, MemberDto>();
                CreateMap<CostCategory, CostCategoryDto>();
            }

}

}