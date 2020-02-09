using System;
namespace Task4_BootcampRefactory
{
    public interface ICart
    {
        ICart addItem(int item_id, int price, int quatity = 1);
        ICart removeItem(int item_id);
        ICart addDiscount(string discount);
    }
}
