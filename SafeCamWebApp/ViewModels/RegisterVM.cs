using System.ComponentModel.DataAnnotations;

namespace SafeCamWebApp.ViewModels.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Ad mütləq daxil edilməlidir")]
        [MinLength(3, ErrorMessage = "Ad ən az 3 simvol olmalıdır")]
        [MaxLength(25, ErrorMessage = "Ad ən çox 25 simvol ola bilər")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad mütləq daxil edilməlidir")]
        [MinLength(3, ErrorMessage = "Soyad ən az 3 simvol olmalıdır")]
        [MaxLength(25, ErrorMessage = "Soyad ən çox 25 simvol ola bilər")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "İstifadəçi adı mütləq daxil edilməlidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email mütləq daxil edilməlidir")]
        [EmailAddress(ErrorMessage = "Düzgün email formatı daxil edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrə mütləq daxil edilməlidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifrə təkrarı mütləq daxil edilməlidir")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifrələr uyğun gəlmir")]
        public string ConfirmPassword { get; set; }
    }
}