#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;

#endregion

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{ 
    /// <summary>
    /// Implementation of ISalePagedRepository using Entity Framework Core
    /// </summary>
    public class SalePagedRepository : ISalePagedRepository
    {
        private readonly DefaultContext _context;
        private readonly DbSet<Sale> _dataSet;

        public SalePagedRepository(DefaultContext context)
        {
            _context = context;
            _dataSet = _context.Set<Sale>();
        }

        /// <summary>
        /// Get sale paged
        /// </summary>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Sale>> GetPaged(string? name, int page, int size)
        {
            return await Select(name).Skip(page * size).Take(size).ToListAsync();
        }

        // Get count sale by name
        public async Task<int> GetCount(string? name)
        {
            return await Select(name).CountAsync();
        }

        /// <summary>
        /// Select get the sales per name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private IQueryable<Sale> Select(string? name)
        {
            return _dataSet
                .Include(x => x.Customer).Where(x => string.IsNullOrEmpty(name) || EF.Functions.Like(x.Customer.Name.ToLower(), string.Concat("%", name.ToLower(), "%")))
                .Include(x => x.Branch)
                .AsNoTracking().AsQueryable();
        }
    }
}
