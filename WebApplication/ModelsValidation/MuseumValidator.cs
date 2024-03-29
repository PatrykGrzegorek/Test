﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApplication.Models;

namespace WebApplication.ModelsValidation
{
    public class MuseumValidator : AbstractValidator<Museum>
    {
        public MuseumValidator()
        {
            RuleFor(d => d.Name)
            .NotEmpty().WithMessage("Museum name is required");
            RuleFor(d => d.Country)
            .NotEmpty().WithMessage("Country name is required");
            RuleFor(d => d.City)
            .NotEmpty().WithMessage("City name is required");
            RuleFor(d => d.StreetName)
            .NotEmpty().WithMessage("Street name is required");
            RuleFor(d => d.StreetNumber)
            .NotEmpty().WithMessage("Street number is required");
            RuleFor(d => d.PostalCode)
            .NotEmpty().WithMessage("Postal code is required");
        }
    }
}
