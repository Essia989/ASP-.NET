#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
namespace ProductsCategories.Models;

public class Association
{
    [Key]
    public int AssociationId {get;set;}
    // The connection to the Product table
    public int ProductId {get;set;}
    public Product? Product {get;set;}
    // The connection to the Category table
    public int CategoryId {get;set;}
    public Category? Category {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}