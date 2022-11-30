using System;
using System.Linq;
using System.Collections.Generic;

class Exam4_1
{  //4.1  დაწერეთ პროგრამა რომელიც მასივში დაითვლის თითოეული ელემენტი რამდენჯერ გვხვდება.

    static void Main(string[] args)
    {
        int[] massive1 = new int[] { 5, 11, 4, 3, 3, 19, 5, 6, 7, 3, 7, 16, 8, 5, 4, 9, 6, 4 };
        Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
        Console.Write("---------------------------------------------------------------------\n");
        Console.Write("The numbers in the array  are : \n");
        Console.Write(" 5, 11, 4, 3, 3, 19, 5, 6, 7, 3, 7, 16, 8, 5, 4, 9, 6, 4\n");

        var n = from x in massive1
                group x by x into z
                select z;
        Console.WriteLine("\nThe number and the Frequency are : \n");
        foreach (var arrNo in n)
        {
            Console.WriteLine("Number " + arrNo.Key + " Turns up " + arrNo.Count() + " times");
        }
        Console.WriteLine("\n");
    }
}

