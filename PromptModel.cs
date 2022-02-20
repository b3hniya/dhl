using System.ComponentModel.DataAnnotations;

class PromptModel
{
    [Display(Name = "Wanna initialize git in your project")]
    [Required]
    public bool GitIgnoreFile { get; set; }
}