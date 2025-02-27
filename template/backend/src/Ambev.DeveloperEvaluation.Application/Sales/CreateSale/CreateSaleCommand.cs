#region Using

using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Command for creating a new sale.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for creating a sale, 
    /// including salename, password, phone number, email, status, and role. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreatesaleResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreatesaleCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        /// <summary>
        /// The customer's key
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// the branch's key
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The discount value
        /// </summary>
        public decimal Discount { get; set; } = 0;

        /// <summary>
        /// The sale status
        /// </summary>
        public SaleStatus Status { get; set; } = SaleStatus.Active;

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// List with products
        /// </summary>
        public List<CreateSaleProduct> Products { get; set; }

        /// <summary>
        /// Obejct Product
        /// </summary>
        public class CreateSaleProduct
        {
            /// <summary>
            /// The product's key
            /// </summary>
            public Guid ProductId { get; set; }

            /// <summary>
            /// the quantity per product
            /// </summary>
            public int Quantity { get; set; }
        }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}