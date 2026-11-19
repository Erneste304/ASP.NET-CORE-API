using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required]
    [StringLength(50)]
    public string? Genre { get; set; }

    [Range(0.01, 1000)]
    public decimal Price { get; set; }
}