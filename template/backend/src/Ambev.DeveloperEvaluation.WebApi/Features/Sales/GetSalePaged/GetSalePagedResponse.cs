using Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    /// <summary>
    /// API response model for GetSalePaged operation
    /// </summary>
    public class GetSalePagedResponse
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
        /// The total per page
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// The object with data
        /// </summary>
        public IEnumerable<SaleForPagedDto>? List { get; set;}
    }
}
