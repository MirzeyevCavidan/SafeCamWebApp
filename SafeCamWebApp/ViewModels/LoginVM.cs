using System.ComponentModel.DataAnnotations;

namespace SafeCamWebApp.ViewModels.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email və ya İstifadəçi adı daxil edilməlidir")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Şifrə daxil edilməlidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsPersisted { get; set; } // "Məni xatırla" funksiyası üçün
    }
}