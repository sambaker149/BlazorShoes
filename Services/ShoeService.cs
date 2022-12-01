using BlazorShoes.Models;

namespace BlazorShoes.Services
{
    public class ShoeService
    {
        public static readonly List<Shoe> Shoes = new List<Shoe>()
        {
            new Shoe()
            {
                ShoeId = 1,
                Name = "Shoe",
                Image = "image.jpg",
                Description = "Test",
                Price = 25
            }
        };
    }
}
