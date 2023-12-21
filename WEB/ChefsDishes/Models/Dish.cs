#pragma warning disable CS8618 

using System.ComponentModel.DataAnnotations;
namespace ChefsDishes.Models;
public class Dish
{
    [Key]
    public int DishID { get; set; }

    [Required]
    public string Name { get; set; } 

    [Required]
    [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5")] // between 1 and 5 
    public int Tastiness { get; set; }

    [Required]
    [Range(0, Double.MaxValue, ErrorMessage = "Calories must be greater than 1.")] // Greater than 0
    public int Calories { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [Required]
    public int ChefId { get; set; }
    // Navigation property for related User object
    public Chef? Creator { get; set; }
}