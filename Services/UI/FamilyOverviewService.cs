using System.Collections.Generic;
using System.Linq;
using Core;
using DAL;
using DAL.Entities;
using Messages.UI.Overview;
using Services.Helpers;

namespace Services.UI
{
    public class FamilyOverviewService
    {
        private readonly AddressDbContext db;

        public FamilyOverviewService(AddressDbContext db)
        {
            this.db = db;
        }

        public List<FamilyViewModel> GetFamilies(string filter)
        {
            var condition = FamilyHelper.BuildWhereCondition(filter);
            var famsDb = db.Families.Where(condition)
                .OrderBy(f => f.LastName).ToList();

            return famsDb.Select(Map).ToList();

            FamilyViewModel Map(Family fam)
            {
                return new FamilyViewModel
                {
                    DisplayName = DisplayName(fam),
                    FirstName = fam.FirstName,
                    LastName = fam.LastName,
                    City = fam.City,
                    Street = fam.Street,
                };
            }

            string DisplayName(Family fam)
            {
                string prefix = fam.Title == Title.FirstName ? fam.FirstName : $"{fam.Title}.";
                return $"{prefix} {fam.LastName}";
            }
        }
    }
}