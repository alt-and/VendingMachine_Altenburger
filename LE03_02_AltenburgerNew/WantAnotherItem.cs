using System;

namespace LE03_02_AltenburgerNew;

public class WantAnotherItem
{
    public static string wasThatAll(int quantity)
    {
        Console.WriteLine("Do you want to add another item?\n['1']Yes\n['2']No");
        string decision = Console.ReadLine();
        if (Equals(decision, "1"))
        {
            Console.Clear();
            checkForItemsInBasket(quantity);
            return decision;
        }
        else if (Equals(decision, "2"))
        { 
            return null;
        }
        else
        {
            ErrorMsG.ErrorMsg(2);
        }

        return null;
    }

    public static bool checkForItemsInBasket(int quantity)
    {
        quantity = quantity - 1;
        int smth = CalculateChange.MoneyList.Count;
        int newsmth = 3-smth;
        if (CalculateChange.MoneyList.Count==3)
        {
            Console.WriteLine("The max amount of items in your Basket is 3!Please go to the Payment next.");
            return false;
        }
        Console.WriteLine("You have " + (CalculateChange.MoneyList.Count+quantity) + " in your basket. You can put " + newsmth + " more things in here x)");
        return true;
    }
}