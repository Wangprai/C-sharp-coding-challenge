using System;

namespace C_sharp_coding_challenge
{
    class Phone
    {
        private string StringInput;
        private string[] Letters = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        public Phone(string stringInput ,string letters)
        {
            StringInput = stringInput;
            Letters = letters;
        }

        public string stringInput
        {
            get { return stringInput; }
            set { return stringInput = value; }
        }

        public string[] Letters
        {
            get { return letters; }
            set { return letters = value; }
        }

        public static string OldPhonePad(string input)
        {
            
        }
    }
}