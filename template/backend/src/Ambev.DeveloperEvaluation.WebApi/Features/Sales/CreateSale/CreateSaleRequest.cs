/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Object with the sale
    /// </summary>
    public class CreateSaleRequest
    {
        /// <summary>
        /// Gets or sets the Key Customer
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the Key Branch
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Gets or sets the Products
        /// </summary>
        public List<SaleProductRequest> Products { get; set; }
    }

    /// <summary>
    /// Object with the products
    /// </summary>
    public class SaleProductRequest
    {
        /// <summary>
        /// Gets or sets the Key Product
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity per product
        /// </summary>
        public int Quantity { get; set; }
    }
}
