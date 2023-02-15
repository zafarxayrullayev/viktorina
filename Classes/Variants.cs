using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Variants
    {
        public string[,] optionDataTypes = {
            { 
                "a) <dataType>.MinValue", 
                "b) .MinValue", 
                "c).MaxValue" 
            },
            { 
                "a) <dataType>.MinValue", 
                "b) .MinValue", 
                "c) <dataType>.MaxValue" 
            }
        };

        public string[,] optionArray = {
            {
                "a) Bir xil tipdagi elementlar to'plami",
                "b) string tipidagi elementlar to'plami",
                "c) Elementlar to'plami"
            },
            {   "a) 1 dan", "b) 0 dan", "c) -1 dan" } 
        };
    }
}
