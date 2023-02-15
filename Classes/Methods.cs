using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Methods
    {
        public void Check(string[] answerArray, string userAnswer, int j)
        {
            if (answerArray[j] == userAnswer)
            {
                Console.WriteLine("To'gri javob, tabriklaymiz!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Xato javob, afus!");
                Console.WriteLine();
            }
        }
    }
}
