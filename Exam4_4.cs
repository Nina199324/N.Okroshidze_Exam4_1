using System;
using System.Linq;

//4.4 დაწერეთ პროგრამა რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.
//x=10 y=20
class Exam4_4
{
    static void Main()
    {
        int[] Matrice1 = {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ,15, 16, 17, 18, 19
            };

        Console.Write("\nLINQ : *We must find the numbers in the list with range after 10 till 20* ");
        Console.Write(" \n The numbers in the array  are : \n");
        Console.Write(" 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ,15 , 16, 17, 18, 19 \n");
        var nQuery =
        from VrNum in Matrice1
        where VrNum > 10
        where VrNum < 20          
        select VrNum;
        Console.Write("\nThe numbers with range after 10 till 20 are : \n");
        foreach (var VrNum in nQuery)
        {
            Console.Write("{0}  ", VrNum);
        }
        Console.Write("\n\n");
    }
}
