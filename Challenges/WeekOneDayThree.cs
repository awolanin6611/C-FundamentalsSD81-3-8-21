using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenges
{
    [TestClass]
    public class WeekOneDayThree
    {

        [TestMethod]
        public void Challenge()
        {
            string word = "Supercalifragilisticexpialidocious";
           foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine(word.Length);
            foreach (char letter in word)
            {
                if (letter == 'i')
                {

                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine("not an I");
                }
            }
        }

    }
}
