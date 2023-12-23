#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
namespace ProductsCategories.Models;

public class Category
{
    [Key]
    public int CategoryId {get;set;}
    [Required]
    public string Name {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    public List<Association> ProdsInCategory { get; set; } = new List<Association>();
}