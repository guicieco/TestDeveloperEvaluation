#region Using

using Ambev.DeveloperEvaluation.Domain.Enums;

#endregion

/// <summary>
/// API response model for GetUser operation
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetSaleResponse
    {
        /// <summary>
        /// The unique identifier of the user
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Sale number
        /// </summary>
        public int SaleNumber { get; set; }

        /// <summary>
        /// The unique identifier of the customer
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The unique identifier of the branch
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The discount value
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Update data
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Sale Status
        /// </summary>
        public SaleStatus Status { get; set; }

        /// <summary>
        /// The total value without discount
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// The total value plus the discount
        /// </summary>
        public decimal TotalDiscount { get; set; }
    }
}
