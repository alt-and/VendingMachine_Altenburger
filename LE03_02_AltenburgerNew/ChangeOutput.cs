using System;
using System.Collections.Generic;

namespace LE03_02_AltenburgerNew;

public class ChangeOutput
{
                                    //Output how much change you get back
    public static void changeOutput(double change)
    {
        {
            Console.WriteLine("Your change is " + change + "Have a nice Day and Thanks for Visiting our Vending Machine!");
            DrinkObj.DrinkList.Clear();
            Snacks.SnackList.Clear();
            CalculateChange.MoneyList.Clear();
        }
    }
}