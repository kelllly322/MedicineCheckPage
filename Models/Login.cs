using System.ComponentModel.DataAnnotations;

namespace MedicineCheckPage.Models
{
    public class Login
    {
        [Key]
        [Display(Name = "用戶名")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string UserName { get; set; }

        [Display(Name = "密碼")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 4)]
        public string Password { get; set; }

        public DateTime LastLoginTime { get; set; }

        public DateTime ChangedPasswordTime { get; set; }

    }
}
