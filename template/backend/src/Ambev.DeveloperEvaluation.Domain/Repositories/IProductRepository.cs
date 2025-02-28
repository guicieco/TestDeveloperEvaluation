#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetByIdAsync(List<Guid> id, CancellationToken cancellationToken = default);
    }
}
