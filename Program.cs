using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] scores ={12, 18, 9, 15,20};
        int total = 0;
        for (int i = 0; i < scores.Length; i++) //changed as cannot equal to 5 as it does not exist
        {
            total += scores[i];
        }

        double average = (double)total / scores.Length; //added double  otherwise it would divide.
        Console.WriteLine($"The average score is: {average}");

        

    }
    static void Names()
    {
        List<string> names = new List<string>();
        names.Add("Sam");
        names.Add("Alex");
        Console.WriteLine("Player names: " + names.Count);  //error before had length

        string word = "Level";
        string reversedWord = ReverseString(word);  // string reversed changed as it need to be a 
        Console.WriteLine($"Reversed word: {reversedWord}");
         for (int i = 0; i < word.Length; i++)
        {
            reversedWord += word[i];

            if (word ==reversedWord);  //changed otherwise it would assign it
            {
                Console.WriteLine("Palindrome");
            
            }
        
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();  
            Array.Reverse(charArray);
            return new string(charArray);
            
        }


       
    }

}