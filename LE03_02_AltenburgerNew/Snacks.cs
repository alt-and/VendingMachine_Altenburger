using System.Collections.Generic;

namespace LE03_02_AltenburgerNew;

public class Snacks: DrinkObj
{
    public static Dictionary<int, Snacks> SnackList = new Dictionary<int, Snacks>(10);

    public Snacks(int itemQuantity, string name, double itemValue, string ingredients, string volumeOf) : base(name, itemValue, ingredients, itemQuantity, volumeOf)
    {
    }

    public static int chooseSniggers(string decision)
    {
        string volumeofdrink = "1";
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        Snacks sniggers = new Snacks(5-quantity, "Sniggers", price, "Zucker, Glukosesirup, Erdnüsse, " +
                                                                   "Magermilchpulver, Kakaobutter", "1");
        addSnackInBasket(decision, sniggers);
        CalculateChange.MoneyList.Add(int.Parse(decision),sniggers.ItemValue);
        return quantity;
    }
    public static int chooseNigNags(string decision)
    {
        string volumeofdrink = "1";
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        Snacks nignags = new Snacks(5-quantity, "NigNags", price, "Stärke, Palmöl, Weizenmehl, Zucker, " +
                                                                  "Salz", "1" );
        addSnackInBasket(decision, nignags);
        CalculateChange.MoneyList.Add(int.Parse(decision),nignags.ItemValue);
        return quantity;
    }
    public static int chooseNiggiways(string decision)
    {
        string volumeofdrink = "1";
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        Snacks niggiways = new Snacks(5-quantity, "Niggiways", price, "Corn Syrup, Sugar, Palm Oil, " +
                                                                      "Skim Milk,Milk Chocolate", "1");
        addSnackInBasket(decision, niggiways);
        CalculateChange.MoneyList.Add(int.Parse(decision),niggiways.ItemValue);
        return quantity;
    }
    public static int chooseKinderNuggets(string decision)
    {
        string volumeofdrink = "1";
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        Snacks kinderNugget = new Snacks(5-quantity, "Kindernugget", price, "Palmöl*, BUTTERREINFETT, " +
                                                                            "Emulgator Lecithine,Zucker, " +
                                                                            "MAGERMILCHPULVER", "1");
        addSnackInBasket(decision, kinderNugget);
        CalculateChange.MoneyList.Add(int.Parse(decision),kinderNugget.ItemValue);
        return quantity;
    }
    public static int chooseNiguenos(string decision)
    {
        string volumeofdrink = "1";
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        Snacks niguenos = new Snacks(5-quantity, "Niguenos", price, "Palmöl*, BUTTERREINFETT, " +
                                                                    "Emulgator Lecithine,Zucker, " +
                                                                    "MAGERMILCHPULVER", "1");
        addSnackInBasket(decision, niguenos);
        CalculateChange.MoneyList.Add(int.Parse(decision),niguenos.ItemValue);
        return quantity;
    }
    public static void addSnackInBasket(string decision, Snacks snack)
    {
        SnackList.Add(int.Parse(decision), snack);
    }
}