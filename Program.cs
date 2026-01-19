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
            Console.WriteLine(Phone.OldPhonePad("33"));  // output: E
            Console.WriteLine(Phone.OldPhonePad("227")); // output: BR
            Console.WriteLine(Phone.OldPhonePad("4433555 555666")); // output: HELLO
        }
    }
}