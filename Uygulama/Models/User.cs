using System.ComponentModel.DataAnnotations;

namespace Uygulama.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name="Kullanıcı"),StringLength(50)]
        public string Name { get; set; }
        [Display(Name="Şifre")]
        public string Password { get; set; }

        public bool IsValid { get; set; }
        public bool IsAdmin { get; set; }
    }
}
