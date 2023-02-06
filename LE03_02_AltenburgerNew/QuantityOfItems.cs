using System;

namespace LE03_02_AltenburgerNew;

public class QuantityOfItems
{
    public static int AskForQuantity()
    {
        try
        { 
            Console.WriteLine("How many do you wanna add to your basket?\n");
            int quantityOf = int.Parse(Console.ReadLine());
            return quantityOf;
           
        }
        catch (Exception)
        {
            ErrorMsG.ErrorMsg(1);
            throw;
        }
    }
}