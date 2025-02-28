#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISalePagedRepository
    {
        Task<IEnumerable<Sale>> GetPaged(string? name, int page, int size);
        Task<int> GetCount(string? name);
    }
}
