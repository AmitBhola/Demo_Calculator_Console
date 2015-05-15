using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Calculator_Console
{
    class Calculator_Functions:Calculator_Interface
    {
        /// <summary>
        /// Function Adds two Numbers Variable 1 and Variable 2 and returns the addition 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Addition in the same data type as the input parameters</returns>
        private long func_Add(long variable1, long variable2)
        {
            return (long)(variable1 + variable2);
        }
        /// <summary>
        /// Function Adds two Numbers Variable 1 and Variable 2 and returns the addition 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Addition in the same data type as the input parameters</returns>
        private int func_Add(int variable1, int variable2)
        {
            return (int)(variable1 + variable2);
        }
        /// <summary>
        /// Function Adds two Numbers Variable 1 and Variable 2 and returns the addition 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Addition in the same data type as the input parameters</returns>
        private short func_Add(short variable1, short variable2)
        {
            return (short)(variable1 + variable2);
        }
        /// <summary>
        /// Function Subtracts two Numbers; Variable 2 is subtracted from Variable 1 and returned 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Subtraction in the same data type as the input parameters</returns>
        private long func_Sub(long variable1, long variable2)
        {
            return (long)(variable1 - variable2);
        }
        /// <summary>
        /// Function Subtracts two Numbers; Variable 2 is subtracted from Variable 1 and returned 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Subtraction in the same data type as the input parameters</returns>
        private int func_Sub(int variable1, int variable2)
        {
            return (int)(variable1 - variable2); 
        }
        /// <summary>
        /// Function Subtracts two Numbers; Variable 2 is subtracted from Variable 1 and returned 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Subtraction in the same data type as the input parameters</returns>
        private short func_Sub(short variable1, short variable2)
        {
            return (short)(variable1 - variable2);
        }
        /// <summary>
        /// Function Multiplies two Numbers 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Multiplication in the same data type as the input parameters</returns>
        private long func_Mul(long variable1, long variable2)
        {
            return (long)(variable1 * variable2);
        }
        /// <summary>
        /// Function Multiplies two Numbers 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Multiplication in the same data type as the input parameters</returns>
        private int func_Mul(int variable1, int variable2)
        {
            return (int)(variable1 * variable2);
        }
        /// <summary>
        /// Function Multiplies two Numbers 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Multiplication in the same data type as the input parameters</returns>
        private short func_Mul(short variable1, short variable2)
        {
            return (short)(variable1 * variable2);
        }
        /// <summary>
        /// Function Divides two Numbers; VAriable 1 is the Divident, Variable 2 is the Divisor 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Divison in the same data type as the input parameters</returns>
        private long func_Div(long variable1, long variable2)
        {
            return (long)(variable1 / variable2);
        }
        /// <summary>
        /// Function Divides two Numbers; VAriable 1 is the Divident, Variable 2 is the Divisor 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Divison in the same data type as the input parameters</returns>
        private int func_Div(int variable1, int variable2)
        {
            return (int)(variable1 / variable2);
        }
        /// <summary>
        /// Function Divides two Numbers; VAriable 1 is the Divident, Variable 2 is the Divisor 
        /// </summary>
        /// <param name="variable1">First Parameter</param>
        /// <param name="variable2">Second Parameter</param>
        /// <returns>Returns the Divison in the same data type as the input parameters</returns>
        private short func_Div(short variable1, short variable2)
        {
            return (short)(variable1 / variable2);
        }



        /// <summary>
        /// Funtion to Handle the Addition function 
        /// Call 16 bit first, then 32 bit then 64 bit version
        /// </summary>
        /// <param name="input"></param>
        public void handleAddition(string input)
        {
            string[] operands = input.Split('+');
            try
            {
                // Call Short version of the Addition
                Console.WriteLine(func_Add(Convert.ToInt16(operands[0]), (Convert.ToInt16(operands[1]))));
                Console.WriteLine("Used 16 bit version of the code");
            }
            catch (OverflowException oe)
            {
                try
                {
                    //Call the Int version of Addition
                    Console.WriteLine(func_Add(Convert.ToInt32(operands[0]), (Convert.ToInt32(operands[1]))));
                    Console.WriteLine("Used 32 bit version of the code");
                }
                catch (OverflowException ooe)
                {
                    try
                    {
                        //Call the Long version of Addition
                        Console.WriteLine(func_Add(Convert.ToInt64(operands[0]), (Convert.ToInt64(operands[1]))));
                        Console.WriteLine("Used 64 bit version of the code");
                    }
                    catch (OverflowException oooe)
                    {
                        oooe = new OverflowException("The numbers are too big to be added. They are causing an overflow exception even while using 64 bit representaions");
                        Console.WriteLine(oooe.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Function to Handle the Subtraction function
        /// Call 16 bit first then 32 bit the 64 bit version
        /// </summary>
        /// <param name="input"></param>
        public void handleSubtraction(string input)
        {

        }
        /// <summary>
        /// Function to Handle Multiplication
        /// Call 16 bit first then 32 bit the 64 bit version
        /// </summary>
        /// <param name="input"></param>
        public void handleMultiplication(string input)
        {

        }
        /// <summary>
        /// Function to Handle Division
        /// Call 16 bit first then 32 bit the 64 bit version 
        /// </summary>
        /// <param name="input"></param>
        public void handleDivision(string input)
        {

        }
    }
}
