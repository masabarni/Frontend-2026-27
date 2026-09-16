using System;

namespace Pallindrome1
{
    class Program
    {
        static void Main()
        {
            string inputText = "";
            string reverseText = "";
            char[] reverse_array = null;
            Console.WriteLine("Palindrome szokereső!");
            Console.WriteLine();
            Console.WriteLine("Kérek egy szót:");
            inputText = Console.ReadLine();

            //reverseText = inputText.Reverse().ToString();
            reverse_array = inputText.ToCharArray();
            Array.Reverse(reverse_array);
            reverseText = new string(reverse_array);
            
            if(inputText.Equals(reverseText))
            {
                Console.WriteLine("A beirt szó palindrom szó!");
            }
            else
            {
                Console.WriteLine("A beirt szó nem palindrom!!");
            }
            Console.WriteLine();
            Console.WriteLine("ENTER-rel lehet kilépni");
            Console.ReadLine();
        }

    }
}
