using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;
#pragma warning disable CS8618


public class User
{
    [Required()]
    [MinLength(2)]
    public string Name { get; set; }

    [Required(ErrorMessage = "the location is required")]
    public string Location { get; set; }

    [Required(ErrorMessage = "the Favorite Languge is required")]
    public string Language { get; set; }
    
    [MinLength(20)]
    public string Comment { get; set; }
}