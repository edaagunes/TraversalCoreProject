using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
	{
		public AppUserRegisterValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage("Lütfen Adınızı Giriniz");
			RuleFor(x=>x.Surname).NotEmpty().WithMessage("Lütfen Soyadınızı Giriniz");
			RuleFor(x=>x.Mail).NotEmpty().WithMessage("Lütfen Mail Adresinizi Giriniz");
			RuleFor(x=>x.Username).NotEmpty().WithMessage("Lütfen Kullanıcı Adınızı Giriniz");
			RuleFor(x=>x.Password).NotEmpty().WithMessage("Lütfen Şifrenizi Giriniz");
			RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Lütfen Tekrar Şifrenizi Giriniz");
			RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Lütfen Tekrar Şifrenizi Giriniz");
			RuleFor(x=>x.Username).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz");
			RuleFor(x=>x.Username).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Giriniz");
			RuleFor(x=>x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler Uyumlu Değil");
		}
	}
}
