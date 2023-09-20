using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Base
{
    public static class QueryableExtension
    {
        public static IQueryable<T> MyIncludes<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
            where T : class
        {
            if (query != null)
            {
                query = includes.Aggregate(query, (a, b) => a.Include(b));
            }

            return query;
        }
    }
}
