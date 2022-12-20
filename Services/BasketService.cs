using BlazorShoes.Models;

namespace BlazorShoes.Services
{
    public class BasketService
    {
        public static List<OrderItem> SelectedItems { get; set; } = new List<OrderItem>();

        public void AddToBasket(int ShoeId)
        {
            if(ShoeInBasket(ShoeId) is false)
            {
                var shoe = ShoeService.Shoes.First(p => p.ShoeId == ShoeId);

                OrderItem item = new OrderItem();

                item.Shoe = shoe;
                item.SalePrice = shoe.Price;
                item.Quantity = 1;
                SelectedItems.Add(item);
            }
        }

        private bool ShoeInBasket(int ShoeId)
        {
            foreach(OrderItem item in SelectedItems)
            {
                if( item.Shoe.ShoeId == ShoeId)
                {
                    item.Quantity++;
                    return true;
                }
            }
            return false;
        }
    }
}