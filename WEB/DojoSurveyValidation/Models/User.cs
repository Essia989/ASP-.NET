using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models;
#pragma warning disable CS8618


public class User
{
    [Required()]
    [MinLength(4)]
    public string Name { get; set; }
    [Required(ErrorMessage = "the favorite color is required")]
    public string Location { get; set; }
    [Required()]
    [Range(-1000, 1000)]
    public int FavNumber { get; set; }
}