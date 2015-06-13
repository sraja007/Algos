using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMultiplication
{
    class BasicMultiplication
    {
        static void Main(string[] args)
        {
                string strInput1, strInput2;
                int iInput1, iInput2;

                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Input1: ");
                        strInput1 = Console.ReadLine();
                        Console.WriteLine("Enter Input2: ");
                        strInput2 = Console.ReadLine();

                        try
                        {
                            iInput1 = Int32.Parse(strInput1);
                            iInput2 = Int32.Parse(strInput2);
                            break; // break if we get valid input
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Incorrect input, please enter correct input");
                        }
                        // continue for invalid input
                    }

                    double finalRes = 0;
                    double lineOutput = 0;
                    double digitMultiplierForInput1 = 1;
                    for (; iInput1 > 0 && iInput2 > 0; )
                    {
                        int digit1 = iInput1 % 10;
                        iInput1 = iInput1 / 10;

                        int tempInput2 = iInput2;
                        int carry = 0;
                        double digitMultiplierForInput2 = 1;
                        double wholeReminder = 0;

                        for (; tempInput2 > 0; )
                        {
                            int digit2 = tempInput2 % 10;
                            tempInput2 = tempInput2 / 10;

                            int digitMulOutput = (digit1 * digit2) + carry;
                            carry = digitMulOutput / 10;
                            int currentReminder = (digitMulOutput % 10);
                            wholeReminder = (currentReminder * digitMultiplierForInput2) + wholeReminder;
                            digitMultiplierForInput2 *= 10;
                        }
                        lineOutput = carry * digitMultiplierForInput2 + wholeReminder;

                        finalRes = lineOutput * digitMultiplierForInput1 + finalRes;
                        digitMultiplierForInput1 *= 10;
                    }

                    Console.WriteLine("Result = " + finalRes);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue -  y/n?");
                    int cProceed = Console.Read();

                    if (cProceed != 'y')
                    {
                        break;
                    }

                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
        }
    }
}
