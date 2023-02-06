using System;

namespace LE03_02_AltenburgerNew;

internal partial class Program
{                                                   //Start of the Programm
    public static void Main(string[] args)
    {
        string decision = "";
        while (decision!="0")
        {                                           //Choose which drink        
            MainMenu.menuText();
            decision = Console.ReadLine();
                                                    //Redirect's you to the Main menu
            MainMenu.mainMenu(decision);
        }
    }
}