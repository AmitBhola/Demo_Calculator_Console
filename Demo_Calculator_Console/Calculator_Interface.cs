using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Calculator_Console
{
    interface Calculator_Interface
    {
        //Declarations for the Add functions
        public Int64 func_Add(Int64 variable1, Int64 variable2 );
        public Int32 func_Add(Int32 variable1, Int32 variable2);
        public Int16 func_Add(Int16 variable1, Int16 variable2)
        {
            return (Int16)(variable1 + variable2);
        }

        //Declarations for the Subtract functions
        public Int64 func_Sub(Int64 variable1, Int64 variable2);
        public Int32 func_Sub(Int32 variable1, Int32 variable2);
        public Int16 func_sub(Int16 variable1, Int16 variable2)
        {
            return (Int16)(variable1 - variable2); 
        }

        //Declarations for the Multiply function
        public Int64 func_Mul(Int64 variable1, Int64 variable2);
        public Int32 func_Mul(Int32 variable1, Int32 variable2);
        public Int16 func_Mul(Int16 variable1, Int16 variable2)
        {
            return (Int16)(variable1 * variable2);
        }

        //Declarations for the Divide function
        public Int64 func_Div(Int64 variable1, Int64 variable2);
        public Int32 func_Div(Int32 variable1, Int32 variable2);
        public Int16 func_Div(Int16 variable1, Int16 variable2)
        {
            return (Int16)(variable1 / variable2);
        }
    }
}
