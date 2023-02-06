using System.Collections.Generic;

namespace LE03_02_AltenburgerNew;

public class DrinkObj
{
    public static Dictionary<int, DrinkObj> DrinkList = new Dictionary<int, DrinkObj>(10);

                                     //Class to make the Object of the wanted Drink!
    public string Name { get; }
    public double ItemValue { get; private set; }
    public string Ingredients { get; }
    public int ItemQUantity { get; private set; }
    
    public string VolumeOf { get; }

    public DrinkObj(string name, double itemValue, string ingredients, int itemQuantity, string volumeOf)
    {
        Name = name;
        Ingredients = ingredients;
        ItemValue = itemValue;
        ItemQUantity = itemQuantity;
        VolumeOf = volumeOf;
    }
    
    public static int chooseCocaCola(string decisison)
    {
        string volumeofdrink = DrinkOptionsMenu.askingForDrinkOption();
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        DrinkObj cola = new DrinkObj("Coca Cola", price, "Wasser, " +
                                                         "Zucker, Kohlensäure, Farbstoff E 150d, Aroma, Säurungsmittel, " +
                                                         "Phosphorsäure, Aroma ,Koffein", 5-quantity, volumeofdrink);
        addDrinkInBasket(decisison,cola);
        CalculateChange.MoneyList.Add(int.Parse(decisison),cola.ItemValue);
        return quantity;
    }
    public static int chooseFanta(string decisison)
    {
        string volumeofdrink = DrinkOptionsMenu.askingForDrinkOption();
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        DrinkObj fanta = new DrinkObj("Fanta", price, "Wasser, " +
                                                              "Zucker, Kohlensäure, Citrus-Extrakt, Orangensaft aus Orangenkonzentrat, " +
                                                              "Säurungsmittel, Phosphorsäure, Aroma", 5-quantity, volumeofdrink);
        
        addDrinkInBasket(decisison,fanta);
        CalculateChange.MoneyList.Add(int.Parse(decisison),fanta.ItemValue);
        return quantity;
    }
    public static int chooseRedBull(string decisison)
    {
        string volumeofdrink = DrinkOptionsMenu.askingForDrinkOption();
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 2.50;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        DrinkObj redbull = new DrinkObj("RedBull", price, "Wasser, " +
                                                              "Zucker, Saccharose, Glucose, Säuerungsmittel (Citronensäure), " +
                                                              "Kohlensäure, TaurinKoffein", 5-quantity, volumeofdrink);
        
        addDrinkInBasket(decisison,redbull);
        CalculateChange.MoneyList.Add(int.Parse(decisison),redbull.ItemValue);
        return quantity;
    }
    public static int chooseEiskaffee(string decisison)
    {
        string volumeofdrink = DrinkOptionsMenu.askingForDrinkOption();
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.69;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        DrinkObj eiskaffee = new DrinkObj("Eiskaffe", price, "Fettarme Milch, " +
                                                                  "Kaffee, Invertzuckersirup, Lactose, Salz, Stabilisator E407, " +
                                                                  "Aroma", 5-quantity, volumeofdrink);
        
        addDrinkInBasket(decisison,eiskaffee);
        CalculateChange.MoneyList.Add(int.Parse(decisison),eiskaffee.ItemValue);
        return quantity;
    }
    public static int chooseFakeBull(string decisison)
    {
        string volumeofdrink = DrinkOptionsMenu.askingForDrinkOption();
        int quantity = QuantityOfItems.AskForQuantity();
        double price = 1.00;
        price = DrinkOptionsMenu.updatePrice(volumeofdrink, price, quantity);
        DrinkObj fakebull = new DrinkObj("FakeBull", price, "Wasser, Zucker, " +
                                                                 "Säuerungsmittel, Kohlendioxid, Säureregulator, Natriumcitrate, " +
                                                                 "Koffein ", 5-quantity, volumeofdrink);
        
        addDrinkInBasket(decisison,fakebull);
        CalculateChange.MoneyList.Add(int.Parse(decisison),fakebull.ItemValue);
        return quantity;
    }
                                        //Add your new Drinks under here!
                                        
                                        
                                        
                                        //And above here!
    public static void addDrinkInBasket(string decision, DrinkObj drink)
    {
        if (!CalculateChange.MoneyList.Count.Equals(3))
        {
            DrinkList.Add(int.Parse(decision), drink);
        }
        else
        {
            ErrorMsG.ErrorMsg(2);
        }
        
    }
    public override string ToString()
    {
        return this.Name + "|\tStock: " + this.ItemQUantity + "|\tCost: " + this.ItemValue + " EUR|\tSize:" + this.VolumeOf + "|\tIngredients: " + this.Ingredients + "\n";
    }
}