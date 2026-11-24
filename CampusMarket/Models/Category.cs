using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace CampusMarket.Models;

[Index(nameof(Name), IsUnique = true)] //constrangerea ca numele categoriei sa fie unic
public class Category
{
    [Key] public int CategoryId { get; set; }
    
    [Required] public string Name { get; set; } =  string.Empty;
    
    public List<Listing> Listings { get; set; } = new List<Listing>();
}