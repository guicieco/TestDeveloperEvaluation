using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class SaleForPagedDto
    {
        /// <summary>
        /// The customer's name
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// The branch's name
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// The sale number
        /// </summary>
        public int SaleNumber { get; set; }

        /// <summary>
        /// The discount value
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// The status of sale
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
