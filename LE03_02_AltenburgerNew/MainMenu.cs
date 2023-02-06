using System;
using System.Collections;
using System.Linq;

namespace LE03_02_AltenburgerNew;

public class MainMenu
{
    public static string mainMenu(string decision)
    {
        //Choose which drink the customer wants
        switch (decision)
        {
            case "1":
                int quantity = DrinkObj.chooseCocaCola( decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "2":
                quantity = DrinkObj.chooseFanta( decision);
                WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "3":
                quantity = DrinkObj.chooseRedBull( decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "4" :
                quantity = DrinkObj.chooseEiskaffee( decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "5":
                quantity = DrinkObj.chooseFakeBull(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "6":
                quantity = Snacks.chooseSniggers(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "7":
                quantity = Snacks.chooseNigNags(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "8":
                quantity = Snacks.chooseNiggiways(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "9":
                quantity = Snacks.chooseKinderNuggets(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "10":
                quantity = Snacks.chooseNiguenos(decision);
                decision = WorkSplit.methodCalling(decision, quantity);
                return decision;

            case "11":
                WorkSplit.methodCalling(decision, 0);
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                ErrorMsG.ErrorMsg(1);
                break;
        }

        return null;
    }
    public static void menuText()
    {
        Console.WriteLine("Hello and Welcome to the snack Machine!The available choices are as following.\n['1']0.5l/1l\tCoca Cola\t[1,50/2,50]\tStock:5" +
                          "\n['2']0.5l/1l\tFanta\t\t[1,50/2,50]\tStock:5\n['3']0.5l/1l\tRedBull\t\t[2,50/3,50]\tStock:5\n['4']0.5l/1l\tEiskaffee\t[1,69/2,69]\tStock:5" +
                          "\n['5']0.5l/1l\tFakeBull\t[1,00/2,00]\tStock:5\n['6']*New*\tSniggers\t[2,50]\t\tStock:5\n['7']*New*\tNigNags\t\t[4,50]\t\tStock:5\n['8']*New*\tNiggiways\t[2,50]\t\tStock:5" +
                          "\n['9']*New*\tKindernuggets\t[5,00]\t\tStock:5\n['10']*New*\tNiguenos\t[2,50]\t\tStock:5\n['11']To go to the Payment!\n'0'.-To quit\n!1l Cost's 1$ More!\n");
    }
}