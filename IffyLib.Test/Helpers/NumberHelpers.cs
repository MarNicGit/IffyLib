using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IffyLib.Helpers;
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
                var randomNumber = IffyLib.Helpers.NumberHelpers.GenerateRandomNumber();
                listOfRandomNumbers.Add(randomNumber);
                Console.WriteLine(randomNumber);
            }

            CollectionAssert.AllItemsAreUnique(listOfRandomNumbers);
        }
    }
}
