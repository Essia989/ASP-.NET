using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace MVCII.Models;
/*public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } 
    public string? Location { get; set; }
    public int Age { get; set; }
}*/




public class User
{
    [Required()]
    [MinLength(2)]
    public string Name { get; set; }
    [Required(ErrorMessage = "the favorite color is required")]
    public string FavColor { get; set; }
    [Required()]
    [Range(-1000, 1000)]
    public int FavNumber { get; set; }
}