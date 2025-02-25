#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DefaultContext _context;

        public SaleRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Sale> CreateAsync(Sale sale, List<SaleProduct> listSaleProducts, CancellationToken cancellationToken = default)
        {
            using var transactionDB = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.Sales.AddAsync(sale, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                listSaleProducts.ForEach(_ => _.SaleId = sale.Id);

                await _context.SaleProducts.AddRangeAsync(listSaleProducts, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                
                await transactionDB.CommitAsync();
            }
            catch(Exception ex)
            {
                await transactionDB.RollbackAsync();
            }

            return sale;
        }

        public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var sale = await GetByIdAsync(id, cancellationToken);
            if (sale == null)
                return await Task.FromResult(false);

            sale.Status = Domain.Enums.SaleStatus.Suspended;
            sale.UpdatedAt = DateTime.UtcNow;

            _context.Update(sale);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(true);
        }
    }
}