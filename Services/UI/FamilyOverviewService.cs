using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Castle.Core.Internal;
using Core;
using DAL;
using DAL.Entities;
using Messages.UI.Overview;
using Microsoft.EntityFrameworkCore;
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
            var condition = BuildWhereCondition();
            var famsDb = db.Families.Where(condition).ToList();

            return famsDb.Select(Map).ToList();

            Expression<Func<Family, bool>> BuildWhereCondition()
            {
                if (filter.IsNullOrEmpty()) return f => true;
                string[] splitted = filter.Trim().Split(' ');

                var whereCondition = AnyFieldLike(splitted[0]);
                for (int i = 1; i < splitted.Length; i++)
                    whereCondition = whereCondition.AndAlso(AnyFieldLike(splitted[i]));

                return whereCondition;
            }

            Expression<Func<Family, bool>> AnyFieldLike(string pattern)
            {
                pattern = $"%{pattern}%";
                return j => EF.Functions.Like(j.FirstName, pattern)
                            || EF.Functions.Like(j.LastName, pattern)
                            || EF.Functions.Like(j.City, pattern);
            }

            FamilyViewModel Map(Family fam)
            {
                return new FamilyViewModel
                {
                    Title = fam.Title == Title.FirstName ? "" : $"{fam.Title}.",
                    NameOverride = fam.NameOverride,
                    FirstName = fam.FirstName,
                    LastName = fam.LastName,
                    City = fam.City,
                    Street = fam.Street,
                };
            }
        }
    }
}