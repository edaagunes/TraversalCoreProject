using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Soyadınız Giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Lütfen Mail Adresiniz Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Tekrar Şifrenizi Giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
		public string ConfirmPassword { get; set; }
	}
}
