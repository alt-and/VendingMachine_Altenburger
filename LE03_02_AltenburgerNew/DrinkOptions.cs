using System;


namespace LE03_02_AltenburgerNew;

public class DrinkOptionsMenu
{
                                    //Choose which drink option you wanna buy
    public static string askingForDrinkOption()
    {
        Console.Clear();
        Console.WriteLine("There are two options, Please choose which option you want to buy!\n'1'.-[0.5l]\n'2'.-[1.5l]");
        string decision = Console.ReadLine();
        return decision;
    }

    public static double updatePrice(string volumeofdrink, double price, int quantity)
    {
        if (volumeofdrink == "1")
        {
            return price*quantity;
        }
        else if(volumeofdrink == "2")
        {
            price = price + 1.00*quantity;
            return price;
        }
        

        return 0;
    }
}