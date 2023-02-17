using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Methods
    {
        public int Count { get; set; }
        public void CheckAndCount(string[] answer, string userAnswer, int j)
        {
            if (answer[j] == userAnswer)
            {
                Console.WriteLine("To'gri javob, tabriklaymiz!");
                Count++;
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
