using System.ComponentModel.DataAnnotations;

namespace ASPNETBOILERPLATE.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}