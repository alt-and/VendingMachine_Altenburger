using System;
using System.Collections.Generic;
using System.Linq;

namespace LE03_02_AltenburgerNew;

public class CalculateChange
{ 
    public static Dictionary<int, double> MoneyList = new Dictionary<int, double>();
    public static void ChangeCalculation(double money)
    {
        if (MoneyList.Count==1)
        {
            double change = money - (MoneyList.Values.ElementAt(0));
            ChangeOutput.changeOutput(change);
        }
        if (MoneyList.Count==2)
        {
            double change = money - (MoneyList.Values.ElementAt(0) + MoneyList.Values.ElementAt(1));
            ChangeOutput.changeOutput(change);
        }
        if (MoneyList.Count==3)
        {
            double change = money - (MoneyList.Values.ElementAt(0) + MoneyList.Values.ElementAt(1) + MoneyList.Values.ElementAt(2));
            ChangeOutput.changeOutput(change);
        }
        
    }
    public static double TotalSumCalculation()
    {
        if (MoneyList.Count==1)
        {
            return MoneyList.Values.ElementAt(0);
        }
        if (MoneyList.Count==2)
        {
            return MoneyList.Values.ElementAt(0) + MoneyList.Values.ElementAt(1);
        }
        if (MoneyList.Count==3)
        {
            return MoneyList.Values.ElementAt(0) + MoneyList.Values.ElementAt(1) + MoneyList.Values.ElementAt(2);
        }
        return 0;
    }
}