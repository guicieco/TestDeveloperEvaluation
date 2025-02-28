#region Using

using Ambev.DeveloperEvaluation.Domain.Enums;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    /// <summary>
    /// Response model for GetSale operation
    /// </summary>
    public class GetSaleResult
    {
        /// <summary>
        /// The unique identifier of the sale
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The sale number
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
        /// The creation date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The sale status
        /// </summary>
        public SaleStatus Status { get; set; }

        /// <summary>
        /// The total without discount
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// The total plus discount
        /// </summary>
        public decimal TotalDiscount { get; set; }
    }
}
