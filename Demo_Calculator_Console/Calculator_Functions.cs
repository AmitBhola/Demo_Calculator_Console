using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Calculator_Console
{
    class Calculator_Functions:Calculator_Interface
    {
        public long func_Add(long variable1, long variable2)
        {
            return (long)(variable1 + variable2);
        }

        public int func_Add(int variable1, int variable2)
        {
            return (int)(variable1 + variable2);
        }

        public short func_Add(short variable1, short variable2)
        {
            return (short)(variable1 + variable2);
        }

        public long func_Sub(long variable1, long variable2)
        {
            throw new NotImplementedException();
        }

        public int func_Sub(int variable1, int variable2)
        {
            throw new NotImplementedException();
        }

        public short func_sub(short variable1, short variable2)
        {
            throw new NotImplementedException();
        }

        public long func_Mul(long variable1, long variable2)
        {
            throw new NotImplementedException();
        }

        public int func_Mul(int variable1, int variable2)
        {
            throw new NotImplementedException();
        }

        public short func_Mul(short variable1, short variable2)
        {
            throw new NotImplementedException();
        }

        public long func_Div(long variable1, long variable2)
        {
            throw new NotImplementedException();
        }

        public int func_Div(int variable1, int variable2)
        {
            throw new NotImplementedException();
        }

        public short func_Div(short variable1, short variable2)
        {
            throw new NotImplementedException();
        }
    }
}
