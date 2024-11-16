using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class GuideValidator : AbstractValidator<Guide>
	{
		public GuideValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage("Rehber Adı Boş Geçilemez");
			RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
			RuleFor(x=>x.Image).NotEmpty().WithMessage("Rehber Görseli Boş Geçilemez");
			RuleFor(x=>x.Name).MaximumLength(30).WithMessage("Maximum 30 Karakter Girilebilir");
		}
	}
}
