#region Using

using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleRequestValidator()
        {
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