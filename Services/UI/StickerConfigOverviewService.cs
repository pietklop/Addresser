using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL;
using Messages.UI.Overview;

namespace Services.UI
{
    public class StickerConfigOverviewService
    {
        private readonly AddressDbContext db;
        private readonly IMapper mapper;

        public StickerConfigOverviewService(AddressDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public List<StickerConfigViewModel> GetConfigs() =>
            db.StickerConfigs.OrderBy(s => s.Name).ProjectTo<StickerConfigViewModel>(mapper.ConfigurationProvider).ToList();
    }
}