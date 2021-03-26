using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace IffyLib.Test.Helpers
{
    public class NumberHelpers
    {
        [Test]
        public void GenerateRandomNumber()
        {
            List<int> listOfRandomNumbers = new List<int>();

            //Add a LOT of random numbers to the list

            for (int i = 0; i < 10000; i++)
            {
                int randomNumber = IffyLib.Helpers.NumberHelpers.GenerateRandomNumber();
                listOfRandomNumbers.Add(randomNumber);
                Console.WriteLine(randomNumber);
            }

            CollectionAssert.AllItemsAreUnique(listOfRandomNumbers);
        }
    }
}
