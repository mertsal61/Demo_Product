using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Değeri Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soy İsim Değeri Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyeti Giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Email Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin Eşleştiğinden Emin Olun")]
        public string ConfirmPassword { get; set; }
    }
}
