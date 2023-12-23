#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
namespace ProductsCategories.Models;

public class Product
{
    [Key]
    public int ProductId {get;set;}
    [Required]
    public string Name {get;set;}
    [Required]
    public string Description {get;set;}
    [Required]
    public double Price {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
    public List<Association> InCategories { get; set; } = new List<Association>(); 
}