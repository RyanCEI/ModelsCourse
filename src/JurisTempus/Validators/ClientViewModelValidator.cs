using FluentValidation;
using JurisTempus.Data;
using JurisTempus.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class ClientViewModelValidator : AbstractValidator<ClientViewModel>
  {
    public ClientViewModelValidator(BillingContext ctx)
    {
      RuleFor(c => c.Name).NotEmpty()
                          .MinimumLength(5)
                          .MaximumLength(100)
                          .MustAsync(async (value, canctok) =>
                          {
                            return !(await ctx.Clients.AnyAsync(c => c.Name == value));
                          })
                          .WithMessage("Name must be unique");
      RuleFor(c => c.ContactName).MaximumLength(50);
      When(c => !string.IsNullOrEmpty(c.Phone) || !string.IsNullOrEmpty(c.ContactName),
        () =>
        {
          RuleFor(c => c.Phone).NotEmpty().WithMessage("Phone cannot be empty if contact is specified");
          RuleFor(c => c.ContactName).NotEmpty().WithMessage("Contact cannot be empty if phone is specified");
        });
    }
  }
}
