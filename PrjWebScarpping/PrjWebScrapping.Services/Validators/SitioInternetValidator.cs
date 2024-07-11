using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjWebScrapping.Domain.Model;

namespace PrjWebScrapping.Services.Validators
{
    public class SitioInternetValidator : AbstractValidator<SitioInternet>
    {
        public SitioInternetValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe o nome do site.")
                .NotNull().WithMessage("Informe o nome do site.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Informe a descrição.")
                .NotNull().WithMessage("Informe a descrição.");

            RuleFor(c => c.EnderecoInternet)
                .NotEmpty().WithMessage("Informe o endereço da internet.")
                .NotNull().WithMessage("Informe o endereço da internet.");
        }
    }
}
