#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DefaultContext _context;

        public ProductRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetByIdAsync(List<Guid> id, CancellationToken cancellationToken = default) => 
            await _context.Products.Where(_ => id.Contains(_.Id)).ToListAsync(cancellationToken: cancellationToken);
    }
}
