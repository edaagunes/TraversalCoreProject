using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {length} Karakter Olmalıdır"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola En Az 1 Büyük Harf İçermelidir"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola En Az 1 Küçük Harf İçermelidir"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola En Az 1 Sembol İçermelidir"
			};
		}

		public override IdentityError PasswordMismatch()
		{
			return new IdentityError()
			{
				Code = "PasswordMismatch",
				Description = $"Girdiğiniz Parolalar Eşleşmedi"
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parola En Az 1 Rakam İçermelidir ('0'-'9')"
			};
		}
	}
}
