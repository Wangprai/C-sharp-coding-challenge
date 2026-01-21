using System;
using System.Text;

namespace C_sharp_coding_challenge
{
    public class Phone
    {
        private string StrInput;
        private static readonly string[] Letters = { 
            "",  // 0
            "",  // 1 
            "ABC",  // 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNO",  // 6
            "PQRS",  // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };

        public Phone(string stringInput)
        {
            StringInput = stringInput;
        }

        public string StringInput
        {
            get { return StrInput; }
            set { StrInput = value; }
        }

        public static string OldPhonePad(string stringInput)
        {
            StringBuilder stringOutput = new StringBuilder();
            int lastDigit = -1;
            int count = 0;

            for (int i = 0; i < stringInput.Length; i++)
            {
                char currentChar = stringInput[i];

                // confirm or space
                if (currentChar == ' ' || currentChar == '#')
                {
                    if (count > 0)
                    {
                        stringOutput.Append(Letters[lastDigit][(count - 1) % Letters[lastDigit].Length]);
                        lastDigit = -1;
                        count = 0;
                    }
                }
                // backspace
                else if (currentChar == '*')
                {
                    if (count > 0)
                    {
                        lastDigit = -1;
                        count = 0;
                    }
                    else if (stringOutput.Length > 0)
                    {
                        // delete last output character
                        stringOutput.Length--;
                    }
                }
                // number 2 - 9
                else if (currentChar >= '2' && currentChar <= '9')
                {
                    int currentDigit = currentChar - '0';

                    if (currentDigit == lastDigit)
                    {
                        count ++;
                    }
                    else
                    {
                        if (count > 0)
                        {
                            stringOutput.Append(Letters[lastDigit][(count - 1) % Letters[lastDigit].Length]);
                        }
                        lastDigit = currentDigit;
                        count = 1;
                    }
                }
            }
            // flush last character
            if (count > 0)
            {
                stringOutput.Append(Letters[lastDigit][(count - 1) % Letters[lastDigit].Length]);
            }
            return stringOutput.ToString();
        }
    }
}