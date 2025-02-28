#region Using

using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public int SaleNumber { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public SaleStatus Status { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDiscount { get; set; }
    }
}
