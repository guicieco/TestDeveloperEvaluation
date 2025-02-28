#region Using

using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;
using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    /// <summary>
    /// Validator for GetSalePagedRequest
    /// </summary
    public class GetSalePagedRequestValidator : AbstractValidator<GetSalePagedRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetSalePagedRequest
        /// </summary>
        public GetSalePagedRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Customer's name is required");
        }
    }
}