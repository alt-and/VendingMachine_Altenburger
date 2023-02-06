using System;

namespace LE03_02_AltenburgerNew;

public class ErrorMsG
{
                                                //Error Msg Output's
    public static void ErrorMsg(int errorNumber)
    {
        if (errorNumber == 1)
        {
            Console.WriteLine("\nMake sure you Fill something in! And to only use Numbers to answer!\n");
        }else if (errorNumber == 2)
        {
            Console.WriteLine("Your error here.");
        }
    }
}