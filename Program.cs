// // See https://aka.ms/new-console-template for more information
using System;

namespace C_sharp_coding_challenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Old phone pad message");
            Console.WriteLine("Test Case:");
            Console.WriteLine(Phone.OldPhonePad("33#"));  // output: E
            Console.WriteLine(Phone.OldPhonePad("227*#")); // output: B
            Console.WriteLine(Phone.OldPhonePad("4433555 555666#")); // output: HELLO
            Console.WriteLine(Phone.OldPhonePad("8 88777444666*664#")); // output: TURING

            // ====================== Playground Section ====================== 
            Console.WriteLine("Try it yourself");
            Console.WriteLine("Input:");

            string? input = Console.ReadLine();
            string result = Phone.OldPhonePad(input);

            Console.WriteLine("Output:"+ result);
        }
    }
}