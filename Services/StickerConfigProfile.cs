using AutoMapper;
using DAL.Entities;
using Messages.UI.Dto;
using Messages.UI.Overview;

namespace Services
{
    public class StickerConfigProfile : Profile
    {
        public StickerConfigProfile()
        {
            CreateMap<StickerConfigDto, StickerConfig>();
            CreateMap<StickerConfig, StickerConfigDto>();
            CreateMap<StickerConfig, StickerConfigViewModel>();
        }
    }
}