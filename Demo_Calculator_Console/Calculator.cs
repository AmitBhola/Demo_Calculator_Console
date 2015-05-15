using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Calculator_Console
{
    class Calculator 
    {
        private static Calculator_Functions cf = new Calculator_Functions();
        static void Main(string[] args)
        {
            //Welcome Message
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Start of the Calculator\n\n");
                Console.WriteLine("Write computaion in the following format Operand_1<Operation>Operand_2\n");
                //Obtain the user input from the screen
                string input = Console.ReadLine();

                if (input.Contains('+'))
                {
                    // Call Appropriate function to handle Input
                    cf.handleAddition(input);
                }
                else if (input.Contains('-'))
                {
                    cf.handleSubtraction(input);
                }
                else if (input.Contains('*'))
                {
                    cf.handleMultiplication(input);
                }
                else if (input.Contains('/'))
                {
                    cf.handleDivision(input);
                }
                else
                {
                    Console.WriteLine("Invalid Format\n ");
                }
                //Pause the output
                Console.ReadLine();
                //Break the While loop
                Console.WriteLine("Press Q/q to Quit | Press any Key to Continue");
                string exit = Console.ReadLine();
                if (exit.Equals("q") || exit.Equals("Q"))
                {
                    break;
                }
                        
            }
        }

    }
}
