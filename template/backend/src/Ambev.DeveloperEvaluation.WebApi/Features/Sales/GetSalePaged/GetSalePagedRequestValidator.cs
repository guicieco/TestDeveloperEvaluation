#region Using

using Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;
using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSalePaged
{
    public class GetSalePagedRequestValidator : AbstractValidator<GetSalePagedRequest>
    {
        /// <summary>
        /// Initializes validation rules for GetUserRequest
        /// </summary>
        public GetSalePagedRequestValidator()
        {
            //RuleFor(x => x.Id)
            //    .NotEmpty()
            //    .WithMessage("Sale ID is required");
        }
    }
}