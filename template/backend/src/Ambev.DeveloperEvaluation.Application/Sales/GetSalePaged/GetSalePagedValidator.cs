#region Using

using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSalePaged
{
    public class GetSalePagedValidator : AbstractValidator<GetSalePagedCommand>
    {
        public GetSalePagedValidator()
        {
            
        }
    }
}