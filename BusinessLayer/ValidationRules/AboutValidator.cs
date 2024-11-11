using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı Boş Geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen En Az 50 Karakterlik Açıklama Giriniz");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama 1500 Karakteri Geçemez");
        }
    }
}
