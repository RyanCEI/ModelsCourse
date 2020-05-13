using FluentValidation;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class TimeBillModelValidator : AbstractValidator<TimeBillViewModel>
  {
    public TimeBillModelValidator()
    {
      RuleFor(b => b.Rate).InclusiveBetween(0m, 500m);
      RuleFor(b => b.TimeSegments).GreaterThan(0);
      RuleFor(b => b.WorkDescription).MinimumLength(10);
      RuleFor(b => b.CaseId).NotEmpty();
      RuleFor(b => b.EmployeeId).NotEmpty();
    }
  }
}
