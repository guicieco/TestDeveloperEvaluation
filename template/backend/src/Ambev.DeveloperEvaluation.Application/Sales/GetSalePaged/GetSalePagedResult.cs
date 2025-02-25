#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class GetSalePagedResult
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public IEnumerable<SaleForPagedDto>? List { get; set; }
    }
}
