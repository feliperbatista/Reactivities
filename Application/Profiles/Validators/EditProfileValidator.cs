using System;
using FluentValidation;
using Application.Profiles.Commands;

namespace Application.Profiles.Validators;

public class EditProfileValidator : AbstractValidator<UpdateProfile.Command>
{
    public EditProfileValidator()
    {
        RuleFor(x => x.DisplayName).NotEmpty();
    }
}
