using System.ComponentModel.DataAnnotations;
namespace Blocket.DataContracts
{
    public record CreateItem
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1,1000)]
        public decimal Price { get; init; }
    }
}
