using System;
using System.Linq;

//4.5   დაწერეთ პროგრამა რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს.
 
namespace LinQ
{    
    class Exam4_5
    {
        public static void Main()
        {
            string str = "I work for HeidelbergCement Georgia";
            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            Console.Write("---------------------------------------------------------------------\n");
            Console.WriteLine("Most Frequent Character is:");
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write(mostFrequentCharacter);
            
        }
    }
}

