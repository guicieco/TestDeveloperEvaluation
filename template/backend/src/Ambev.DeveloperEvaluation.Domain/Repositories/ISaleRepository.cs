#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale> CreateAsync(Sale sale, List<SaleProduct> listSaleProducts, CancellationToken cancellationToken = default);
        Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
