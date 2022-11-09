namespace Blocket.DataContracts
{
    public record CreateItem
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
