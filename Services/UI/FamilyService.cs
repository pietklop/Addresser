using System;
using System.Linq;
using DAL;
using DAL.Entities;
using Messages.UI.Dto;

namespace Services.UI
{
    public class FamilyService
    {
        private readonly AddressDbContext db;

        public FamilyService(AddressDbContext db)
        {
            this.db = db;
        }

        public FamilyDto GetBy(string firstName, string lastName)
        {
            var famDb = GetByOrDefault(firstName, lastName);

            var famDto = new FamilyDto();
            famDto.Id = famDb.Id;
            famDto.Title = famDb.Title;
            famDto.NameOverride = famDb.NameOverride;
            famDto.FirstName = famDb.FirstName;
            famDto.LastName = famDb.LastName;
            famDto.ZipCode = famDb.ZipCode;
            famDto.Street = famDb.Street;
            famDto.City = famDb.City;

            return famDto;
        }

        private Family GetByOrDefault(string firstName, string lastName) => db.Families.SingleOrDefault(f => f.FirstName == firstName && f.LastName == lastName);

        public void Save(FamilyDto famDto)
        {
            Family famDb = null;

            if (famDto.Id > 0)
                famDb = db.Families.Find(famDto.Id);
            else
            {
                famDb = GetByOrDefault(famDto.FirstName, famDto.LastName);
                if (famDb != null) throw new Exception($"Duplicate entry");
            }

            Map();

            db.SaveChanges();

            void Map()
            {
                if (famDb == null)
                {
                    famDb = new Family();
                    db.Add(famDb);
                }
                famDb.Id = famDto.Id;
                famDb.Title = famDto.Title;
                famDb.NameOverride = famDto.NameOverride;
                famDb.FirstName = famDto.FirstName;
                famDb.LastName = famDto.LastName;
                famDb.ZipCode = famDto.ZipCode;
                famDb.Street = famDto.Street;
                famDb.City = famDto.City;
            }
        }

        public void Delete(FamilyDto famDto)
        {
            var famDb = db.Families.Find(famDto.Id);
            db.Families.Remove(famDb);

            db.SaveChanges();
        }
    }
}