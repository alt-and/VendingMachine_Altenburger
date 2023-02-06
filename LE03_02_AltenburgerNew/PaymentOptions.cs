using System;

namespace LE03_02_AltenburgerNew;

public class PaymentOptions
{
    public static void paymentOptions(double totalSum)
    {
                                            //Choose Payment option!
                                            
        Console.Clear();
        Console.WriteLine("Ok!You're total is: " + totalSum + "EUR How do you want to pay?\\tSadly the Max amount you can pay with is 20EUR!\\n");
        double money = checkForNumber(Console.ReadLine());
        if(money !>= 5)
        {
            CalculateChange.ChangeCalculation(money);
        }
        else
        {
            ErrorMsG.ErrorMsg(2);
            paymentOptions(totalSum);
        }
        
    }

    public static double checkForNumber(string decision)
    {
        double sum;
        bool working = double.TryParse(decision, out sum);
        
        if (working)
        {
            return sum;
        }

        return 0;
    }
}