using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IsPalindrome("12");
            IsPalindrome("11");
            IsPalindrome("Deleveled");
            IsPalindrome("A_nn_A");
            


            Console.ReadKey();

             

        }

        static void IsPalindrome(string input)
            {


            string reverse;

            char[] ch = input.ToCharArray();

            Array.Reverse(ch);
            reverse = new string(ch);
            bool b = input.Equals(reverse, StringComparison.InvariantCultureIgnoreCase);

   
            if (b == true)
            {
                Console.WriteLine("" + input + " is a palindrome");
            }
            else
            {
                Console.WriteLine("" + input + " is not a palindrome");
            }


          
        }
        



    }
}

