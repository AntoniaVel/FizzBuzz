using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzNumbers
    {
        public void PrintNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetMessage(i) + "\n");
            }
        }

        private string GetMessage(int number)
        {
            string message = "";

            if (number % 3 == 0)
                message = "Fizz";

            if (number % 5 == 0)
                return message += "Buzz";

            return message == "" ? number.ToString() : message;
        }
    }
}
