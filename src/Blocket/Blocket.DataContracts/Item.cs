using System;
namespace Blocket.DataContracts
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public DateTime Created { get; set; }
    }
}
