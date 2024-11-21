using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUsValidationRules
{
	public class SendContactUsValidator : AbstractValidator<SendMessageDto>
	{
		public SendContactUsValidator()
		{
			RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
			RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
			RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
			RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("5 karakterden az mesaj girilemez.");
			RuleFor(x => x.Subject).MinimumLength(5).WithMessage("5 karakterden az konu girilemez.");
		}
	}
}
