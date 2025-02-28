#region Using

using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    /// <summary>
    /// Validator for GetSalePagedCommand
    /// </summary>
    public class GetSalePagedValidator : AbstractValidator<GetSalePagedCommand>
    {
        /// <summary>
        /// Initializes validation rules for GetSalePagedCommand
        /// </summary>
        public GetSalePagedValidator()
        {
            
        }
    }
}