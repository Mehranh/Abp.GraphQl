using System.ComponentModel.DataAnnotations;

namespace GraphQl.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}