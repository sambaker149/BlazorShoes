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
                Name = "Shoe 1",
                Image = "image.jpg",
                Description = "Test 1",
                Price = 25
            },
           new Shoe()
            {
                ShoeId = 2,
                Name = "Shoe 2",
                Image = "image.jpg",
                Description = "Test 2",
                Price = 25
            }
        };
    }
}
