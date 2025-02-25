#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;

#endregion

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SalePagedRepository : ISalePagedRepository
    {
        private readonly DefaultContext _context;
        private readonly DbSet<Sale> _dataSet;

        public SalePagedRepository(DefaultContext context)
        {
            _context = context;
            _dataSet = _context.Set<Sale>();
        }

        public async Task<IEnumerable<Sale>> GetPaged(string? name, int page, int size)
        {
            return await Select(name).Skip(page * size).Take(size).ToListAsync();
        }

        public async Task<int> GetCount(string? name)
        {
            return await Select(name).CountAsync();
        }

        private IQueryable<Sale> Select(string? name)
        {
            return _dataSet
                .Include(x => x.Customer).Where(x => string.IsNullOrEmpty(name) || EF.Functions.Like(x.Customer.Name.ToLower(), string.Concat("%", name.ToLower(), "%")))
                .Include(x => x.Branch)
                .AsNoTracking().AsQueryable();
        }
    }
}
