using System.ComponentModel.DataAnnotations;

namespace Scraper.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}