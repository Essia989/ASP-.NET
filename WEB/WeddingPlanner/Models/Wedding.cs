#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
    
public class Wedding
{
    [Key]
    public int WeddingID { get; set; } 
    [Required]
    [MinLength(2, ErrorMessage="Please Provide a minimum lenght value of 3 characters")]
    public string WedderOne { get; set; }
    [Required]
    [MinLength(8, ErrorMessage="Please Provide a minimum lenght value of 3 characters")]
    public string WedderTwo { get; set; } 
    [Required]
    public DateTime Date {get;set;}
    [Required]
    public string Address { get; set; } 
    public int GuestCount {get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}