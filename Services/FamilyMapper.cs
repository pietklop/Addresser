using DAL.Entities;
using Messages.UI.Dto;

namespace Services
{
    public static class FamilyMapper
    {
        public static FamilyDto Map(Family fam)
        {
            return new FamilyDto
            {
                Id = fam.Id,
                Title = fam.Title,
                NameOverride = fam.NameOverride,
                FirstName = fam.FirstName,
                LastName = fam.LastName,
                City = fam.City,
                Street = fam.Street,
                ZipCode = fam.ZipCode,
            };
        }


        public static Family Map(FamilyDto famDto, Family famDb)
        {
            famDb.Id = famDto.Id;
            famDb.Title = famDto.Title;
            famDb.NameOverride = famDto.NameOverride;
            famDb.FirstName = famDto.FirstName;
            famDb.LastName = famDto.LastName;
            famDb.ZipCode = famDto.ZipCode;
            famDb.Street = famDto.Street;
            famDb.City = famDto.City;

            return famDb;
        }
    }
}