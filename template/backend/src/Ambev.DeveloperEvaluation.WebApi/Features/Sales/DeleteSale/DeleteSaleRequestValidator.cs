﻿#region Using

using Ambev.DeveloperEvaluation.WebApi.Features.Users.DeleteUser;
using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    /// <summary>
    /// Validator for DeleteSaleRequest
    /// </summary>
    public class DeleteSaleRequestValidator : AbstractValidator<DeleteSaleRequest>
    {
        /// <summary>
        /// Initializes validation rules for DeleteSaleRequest
        /// </summary>
        public DeleteSaleRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Sale ID is required");
        }
    }
}