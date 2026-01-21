using System;
using System.ComponentModel;
using System.Text;

namespace C_sharp_coding_challenge
{
    public class Phone
    {
        private string StringInput;
        private static readonly string[] Letters = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        public Phone(string stringInput)
        {
            StringInput = stringInput;
        }

        public string stringInput
        {
            get { return StringInput; }
            set { StringInput = value; }
        }

        public static string OldPhonePad(string stringInput)
        {
            StringBuilder stringOutput = new StringBuilder();
            int lastDigit = -1;
            int count = 0;

            for (int i = 0; i < stringInput.Length; i++)
            {
                char currentChar = stringInput[i];
                if (currentChar == ' ')
                {
                    if (count > 0)
                    {
                        stringOutput.Append(Letters[lastDigit][(count - 1) % Letters[lastDigit].Length]);
                        lastDigit = -1;
                        count = 0;
                    }
                }

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

            if (count > 0)
            {
                stringOutput.Append(Letters[lastDigit][(count - 1) % Letters[lastDigit].Length]);
            }
            return stringOutput.ToString();
        }
    }
}