using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
	public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDto>
	{
		public AnnouncementUpdateValidator()
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlık Giriniz");
			RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriği Giriniz");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz");
			RuleFor(x => x.Content).MinimumLength(10).WithMessage("Lütfen En Az 10 Karakter Giriniz");
			RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Giriniz");
			RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen En Fazla 500 Karakter Giriniz");
		}
	}
}
