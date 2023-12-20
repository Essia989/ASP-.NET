#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
    
public class User
{
    [Key]
    public int UserId { get; set; } 
    [Required]
    [MinLength(2, ErrorMessage="FirstName must be 2 characters or longer!")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(8, ErrorMessage="LastName must be 2 characters or longer!")]
    public string LastName { get; set; } 
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password { get; set; } 
    [NotMapped] // Will not be mapped to your users table!
    [Compare("Password")]
    [DataType(DataType.Password)] 
    public string PassConfirm { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}    

