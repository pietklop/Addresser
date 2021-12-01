using System;
using System.Linq.Expressions;
using Castle.Core.Internal;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Services.Helpers
{
    public static class FamilyHelper
    {
        public static Expression<Func<Family, bool>> BuildWhereCondition(string filter)
        {
            if (filter.IsNullOrEmpty()) return f => true;
            string[] splitted = filter.Trim().Split(' ');

            var whereCondition = AnyFieldLike(splitted[0]);
            for (int i = 1; i < splitted.Length; i++)
                whereCondition = whereCondition.AndAlso(AnyFieldLike(splitted[i]));

            return whereCondition;
        }

        private static Expression<Func<Family, bool>> AnyFieldLike(string pattern)
        {
            pattern = $"%{pattern}%";
            return j => EF.Functions.Like(j.FirstName, pattern)
                        || EF.Functions.Like(j.LastName, pattern)
                        || EF.Functions.Like(j.City, pattern);
        }

    }
}