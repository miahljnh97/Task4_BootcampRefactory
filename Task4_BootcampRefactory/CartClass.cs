using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task4_BootcampRefactory
{
    public interface ICart
    {
        int Item_id { get; set; }
        int Price { get; set; } 
        int Quantity { get; set; }
    }

    public class Cart : ICart
    {

        static string cartPath = @"/Users/user/Projects/Task4_BootcampRefactory/Task4_BootcampRefactory/Cart.txt";
        public int Item_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        static List<ICart> itemCart = new List<ICart>();

        public Cart AddItem(int id, int price, int qty = 1)
        {
            var obj = new Cart();
            obj.Item_id = id;
            obj.Price = price;
            obj.Quantity = qty;
            itemCart.Add(obj);
            return this;
        }

        public Cart RemoveItem(int id)
        {
            var obj = itemCart;
            var newObj = new List<ICart>();
            foreach (var k in obj)
            {
                if (k.Item_id != id)
                {
                    newObj.Add(k);
                }
            }
            itemCart = newObj;
            return this;
        }

        public Cart AddDiscount(int id)
        {
            var obj = itemCart;
            foreach (var k in obj)
            {
                k.Price = k.Price * id / 100;
            }
            itemCart = obj;
            return this;
        }

        public static int TotalItems()
        {
            return itemCart.Count();
        }

        public static int TotalQuantity()
        {
            int totalQty = 0;
            foreach (var k in itemCart)
            {
                totalQty += k.Quantity;
            }
            return totalQty;
        }

        public static int TotalPrice()
        {
            int totalPrice = 0;
            foreach (var k in itemCart)
            {
                totalPrice += k.Price * k.Quantity;
            }
            return totalPrice;
        }

        public static string ShowAllItems()
        {
            var allItems = new List<string>();
            foreach (var k in itemCart)
            {
                allItems.Add(k.Item_id.ToString());
            }
            allItems.Distinct();
            return String.Join(',', allItems);
        }

        public static void Checkout()
        {
            List<string> lines = new List<string>();

            lines.Add("Item_id,Price,Qty");

            foreach (var k in itemCart)
            {
                lines.Add($"{k.Item_id},{k.Price},{k.Quantity}");
            }
            File.WriteAllLines(cartPath, lines);
        }
    }
}
