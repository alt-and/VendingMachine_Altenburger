namespace LE03_02_AltenburgerNew;

public class WorkSplit
{
    public static string methodCalling(string decision, int quantity)
    {
        double totalSum = CalculateChange.TotalSumCalculation();
        if (!Equals(decision, "11") )
        {
            decision = WantAnotherItem.wasThatAll(quantity);
        }else if (Equals(decision,"11"))
        {
            PaymentOptions.paymentOptions(totalSum);
        }
        return decision;
    }

}