using System;

namespace Deliverable_2_Unit_1_Vibha_Kondur
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checksum = 0;

            Console.WriteLine("What is your message?");
            input = Console.ReadLine().ToUpper();

            string alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int x = 0; x < input.Length; ++x)
            {
                char letter = input[x];
                //int index = alphabetIndexOf(letter);
                int index = 0;
                for (int y = 0; y < alphabet.Length; ++y)
                {
                    if (alphabet[y] == letter)
                    {
                        index = y;
                    }
                }

                if (x == input.Length - 1)
                {
                    // On the last letter in the message, don't add a dash
                    message += index;
                }
                else
                {
                    message += index + "-";
                }
                int unicodeVal = index + 64;
                checksum += unicodeVal;
            }


            Console.WriteLine("The encoded message is: " + message);

            Console.WriteLine("The checksum is:" + checksum);


            Console.ReadLine();
        }
    }
}
        
    

