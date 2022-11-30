
using System;
using System.Linq;
using System.Collections.Generic;

//4.3 დაწერეთ პროგრამა რომელიც სტრინგში (წინადადებაში იპოვნის uppercase-იან სიტყვბს და დაბეჭდავს მათ)


class Exam4_3
{
    static void Main(string[] args)
    {

        Console.Write("\n Find the UPPERCASE words in a string : ");
        Console.Write("\n----------------------------------------------\n");

        string stringNew;

        Console.Write("Input the string : ");
        stringNew = Console.ReadLine();

        var ucWord = WordFilt(stringNew);
        Console.Write("\n < The UPPER CASE words are > :\n ");
        foreach (string strRet in ucWord)
        {
            Console.WriteLine(strRet);
        }
        Console.ReadLine();
    }

    static IEnumerable<string> WordFilt(string mystr)
    {
        var wordforward = mystr.Split(' ')
                    .Where(x => String.Equals(x, x.ToUpper(),
                    StringComparison.Ordinal));

        return wordforward;

    }
}
