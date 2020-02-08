using System;
namespace Task4_BootcampRefactory
{
    public interface ICart
    {
        ICart AddItem(int item_id, int price, int quantity = 1);
        ICart RemoveItem(int item_id);
        ICart AddDiscount(string disc);
    }
}
