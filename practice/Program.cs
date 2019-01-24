using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMG");

            string myNumber = "1.2345";
            string[] numParts = myNumber.Split('.');

            string wholeNum = numParts[0];
            string decimalPart = numParts[1];

            if (decimalPart.Length == 1)
            {
                decimalPart = decimalPart + "0";
            }
            else if (decimalPart.Length > 2)
            {
                decimalPart = decimalPart.Substring(0,2);
            }
            else
            {
                decimalPart = "00";
            }

            string finalAnswer = wholeNum + "." + decimalPart;

        }
    }
}
