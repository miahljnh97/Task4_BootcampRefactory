using System;
namespace Task4_BootcampRefactory
{
    public class Cart : ICart
    {
        public int Item_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Cart()
        {
            
        }
    }
}
