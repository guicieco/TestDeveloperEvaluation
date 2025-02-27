#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    /// <summary>
    /// Response model for GetSale operation
    /// </summary>
    public class GetSalePagedResult
    {
        /// <summary>
        /// The total of items
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The page size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// The sale data
        /// </summary>
        public IEnumerable<SaleForPagedDto>? List { get; set; }
    }
}
