#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstEntityFrameworkApp.Models;


public class User
{
    [Key]
    [Required]
    public int UserId { get; set; }
    [Required]
    [MinLength(3)]
    public string UserName { get; set; }

    [Required]
    public string UserEmail{ get; set; }

    public DateTime createdAt { get; set;} = DateTime.Now;
    public DateTime UpdatedAt { get; set;} = DateTime.Now;
}

/*
public class Monster
{
    [Key]
    public int MonsterId { get; set; }
    public string Name { get; set; } 
    public int Height { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}*/
