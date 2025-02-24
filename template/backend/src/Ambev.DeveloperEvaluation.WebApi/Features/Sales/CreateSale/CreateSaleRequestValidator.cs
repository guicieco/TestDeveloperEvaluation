#region Using

using FluentValidation;

#endregion

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleRequestValidator()
        {
            //RuleFor(user => user.Email).SetValidator(new EmailValidator());
            //RuleFor(user => user.Discount).NotEmpty().Length(3, 50);
            //RuleFor(user => user.Password).SetValidator(new PasswordValidator());
            //RuleFor(user => user.Phone).Matches(@"^\+?[1-9]\d{1,14}$");
            //RuleFor(user => user.Status).NotEqual(UserStatus.Unknown);
            //RuleFor(user => user.Role).NotEqual(UserRole.None);
        }
    }
}