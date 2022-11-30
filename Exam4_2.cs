using System;
using System.Linq;
using System.Collections.Generic;

//4.2 დაწერეთ პროგრამა, რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება.
class Class2
{
    static void Main(string[] args)
    {
        string str;

        Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
        Console.Write("\n----------------------------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        Console.Write("\n");

        var FrequencyF = from x in str
                   group x by x into y
                   select y;
        Console.Write("The frequency of the characters for your string are:\n");
        foreach (var ArrEle in FrequencyF)
        {
            Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
        }
    }
}