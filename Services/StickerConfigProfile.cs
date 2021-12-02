using AutoMapper;
using DAL.Entities;
using Messages.UI.Dto;

namespace Services
{
    public class StickerConfigProfile : Profile
    {
        public StickerConfigProfile()
        {
            CreateMap<StickerConfigDto, StickerConfig>();
            CreateMap<StickerConfig, StickerConfigDto>();
        }
    }
}