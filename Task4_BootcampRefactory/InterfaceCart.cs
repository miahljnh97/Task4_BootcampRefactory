using System;
namespace Task4_BootcampRefactory
{
    public interface InterfaceCart
    {
        InterfaceCart addItem(int item_id, int price, int quantity = 1);
        InterfaceCart removeItem(int item_id);
        InterfaceCart addDiscount(string disc);
    }
}
