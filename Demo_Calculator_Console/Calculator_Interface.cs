using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Calculator_Console
{
    interface Calculator_Interface
    {
        void handleAddition(string input);
        void handleMultiplication(string input);
        void handleSubtraction(string input);
        void handleDivision(string input);
    }
}
