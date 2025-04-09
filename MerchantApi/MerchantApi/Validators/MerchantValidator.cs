using FluentValidation;
using MerchantApi.Model;

public class MerchantValidator : AbstractValidator<Merchant>
{
    public MerchantValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(10, 50).WithMessage("Name must be between 10 and 50 characters.");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Address is required.")
            .Length(5, 100).WithMessage("Address must be between 5 and 100 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email address.");

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Phone number is required.")
            .Matches(@"^\d{10}$").WithMessage("Invalid phone number. Must be 10 digits.");

        RuleFor(x => x.OpenDate)
            .NotEmpty().WithMessage("Open date is required.");
    }
}