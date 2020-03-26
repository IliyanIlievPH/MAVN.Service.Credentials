using FluentValidation;
using JetBrains.Annotations;
using Lykke.Service.Credentials.Client.Models.Requests;
using Lykke.Service.Credentials.Domain.Services;

namespace Lykke.Service.Credentials.Models.Validation
{
    [UsedImplicitly]
    public class AdminCredentialsUpdateRequestValidator : AbstractValidator<AdminCredentialsUpdateRequest>
    {
        public AdminCredentialsUpdateRequestValidator(IPasswordValidator passwordValidator)
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(o => o.AdminId)
                .NotEmpty()
                .WithMessage("Admin id required.");

            RuleFor(o => o.Login)
                .NotEmpty()
                .WithMessage("Email required.")
                .EmailAddress()
                .WithMessage("Email invalid.");

            RuleFor(o => o.Password)
                .NotEmpty()
                .WithMessage("Password required.")
                .Must(passwordValidator.IsValidPassword)
                .WithMessage(passwordValidator.BuildValidationMessage());
        }
    }
}