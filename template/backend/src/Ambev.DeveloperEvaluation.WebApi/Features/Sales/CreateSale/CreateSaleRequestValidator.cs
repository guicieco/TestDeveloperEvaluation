#region Using

using FluentValidation;

#endregion

/// <summary>
/// Validator for CreateUserRequest that defines validation rules for sale creation.
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleRequestValidator()
        {
            /// <summary>
            /// Check: This rule checks if any product has more than 20 items
            /// </summary>
            RuleForEach(x => x.Products)
            .ChildRules(products =>
            {
                products.RuleFor(p => p.Quantity)
                    .LessThanOrEqualTo(20)
                    .WithMessage("It's not allowed to sell more than 20 of the same products");
            });
        }
    }
}