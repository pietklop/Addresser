using System.Linq;
using AutoMapper;
using DAL;
using DAL.Entities;
using Messages.UI.Dto;

namespace Services
{
    public class StickerConfigService
    {
        private readonly AddressDbContext db;
        private readonly IMapper mapper;

        public StickerConfigService(AddressDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public StickerConfigDto GetBy(string name)
        {
            var listDb = GetByOrDefault(name);

            return mapper.Map<StickerConfigDto>(listDb);
        }

        private StickerConfig GetByOrDefault(string name) => db.StickerConfigs.SingleOrDefault(f => f.Name == name);

        public void Save(StickerConfigDto scDto)
        {
            var scDb = GetByOrDefault(scDto.Name);

            if (scDb == null)
            {
                scDb = new StickerConfig();
                db.Add(scDb);
            }

            mapper.Map(scDto, scDb);

            db.SaveChanges();
        }

        public void Delete(string name)
        {
            var scDb = GetByOrDefault(name);

            if (scDb == null) return;

            db.Remove(scDb);
            db.SaveChanges();
        }
    }
}