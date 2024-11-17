using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.CityDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
	public class MapProfile : Profile
	{
		public MapProfile()
		{
			CreateMap<AnnouncementAddDto, Announcement>();
			CreateMap<Announcement, AnnouncementAddDto>();

			CreateMap<AppUserRegisterDTOs, AppUser>();
			CreateMap<AppUser, AppUserRegisterDTOs>();

			CreateMap<AppUserLoginDTOs, AppUser>();
			CreateMap<AppUser, AppUserLoginDTOs>();

			CreateMap<AnnouncementListDTO, Announcement>();
			CreateMap<Announcement, AnnouncementListDTO>();


			CreateMap<AnnouncementUpdateDto, Announcement>();
			CreateMap<Announcement, AnnouncementUpdateDto>();
		}
	}
}
