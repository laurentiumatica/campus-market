using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace CampusMarket.Models;

public enum ProductCondition //enum pentru conditia in care este produsul
{
    Nou = 0,
    CaNou = 1,
    Folosit = 2
}

public enum ListingApprovalStatus //enum pentru statusul de aprobare al listing-ului
{
    InAsteptare = 0,
    Aprobat = 1,
    Respins = 2
}

public class Listing
{
    [Key] public int ListingId { get; set; }
    
    [Required] public string Title { get; set; } = string.Empty;
    
    [Required] public string Description { get; set; } = string.Empty;
    
    [Required] public string ImageUrl { get; set; } = string.Empty;
    
    [Precision(18,2)] [Range(0.0,9999.0,MinimumIsExclusive = true, ErrorMessage = "Pretul trebuie sa fie o valoare strict pozitiva!")]
    public decimal Price { get; set; } = 0; //punem RangeAttribute cu MinimumIsExclusive = true ca sa impunem conditia Price > 0
    
    [Range(0,9999,ErrorMessage = "Stocul trebuie sa fie o valoare mai mare sau egala cu 0!")]
    public int Stock { get; set; } = 0; //same ca mai sus dar fara excluderea minimului din range, pentru Stock >= 0
    
    [Required] public ProductCondition? Condition { get; set; } = null; //nullable ca sa nu setam Nou/Ca Nou/Folosit by default pentru un nou listing
    
    public ListingApprovalStatus ApprovalStatus { get; set; } = ListingApprovalStatus.InAsteptare; //default InAsteptare
    
    public string AdminFeedback { get; set; } = string.Empty;
    
    [Range(1,5,ErrorMessage = "Puteti acorda o nota de la 1 la 5 (inclusiv)!")] 
    
    public double? AverageRating { get; set; } = null; //RangeAttribute pentru Rating de la 1 la 5. Nullable pentru ca se recalculeaza
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public int CategoryId { get; set; }
    
    public Category? Category { get; set; }
}