using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IffyLib.Helpers
{
    public static class NumberHelpers
    {
        /// <summary>
        /// Generates a number that's (possibly) random
        /// </summary>
        public static int GenerateRandomNumber()
        {
            //First we get a global unique identifier because it looks like a random string
            Guid guid = Guid.NewGuid();

            //Now we find all the numbers in the guid and add them together into a string

            string numbers = "";

            foreach (char c in guid.ToString())
            {
                if (int.TryParse(c.ToString(), out int parsedChar))
                {
                    numbers += parsedChar;
                }
            }

            //scramble the number so it's REALLY random
            Random randomizer = new Random();
            string scrambledNumbers = "";
            foreach (char number in numbers.OrderBy(c=> randomizer.Next()))
            {
                scrambledNumbers += number;
            }

            //Because integers can't be bigger than 2147483647 we have to make it smaller first

            BigInteger bigInt = BigInteger.Parse(scrambledNumbers);

            while (bigInt >= int.MaxValue)
            {
                bigInt /= 2;
            }

            return (int)bigInt;
            
        }
    }
}
