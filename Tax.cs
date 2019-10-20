﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_379
{
    public class Tax
    {
        //you can make these public and a constant to use them in this class and the test class
        public const double BracketOneCap = 10000;
        public const double BracketTwoCap = 30000;
        public const double BracketThreeCap = 100000;

        public const double BracketOneRate = 0.0;
        public const double BracketTwoRate = 0.1;
        public const double BracketThreeRate = 0.25;
        public const double BracketFourRate = 0.4;

        public double taxes;

        public Tax() { }

        public void PrintChart()
        {
            Console.WriteLine("Hello There! Welcome to the tax program.");
            Console.WriteLine("Below is a breakdown of the tax brackets and the their rates.");
            Console.WriteLine("");
            Console.WriteLine("Bracket      Cap         Rate");
            Console.WriteLine("_____________________________");
            Console.WriteLine("1            10000        0%");
            Console.WriteLine("2            30000       10%");
            Console.WriteLine("3            100000      25%");
            Console.WriteLine("4            100000+     40%");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        // better to return a double than edit within this method
        public double TaxOwed(double income)
        {
            if (income >= BracketOneCap)
            {
                if (income >= BracketTwoCap)
                {
                    if (income >= BracketThreeCap)
                    {
                        double taxableIncome = income - BracketThreeCap;
                        //removing taxes usage since it now can be returned
                        return (taxableIncome * BracketFourRate) + ((BracketThreeCap - BracketTwoCap) * BracketThreeRate) + ((BracketTwoCap - BracketOneCap) * BracketTwoRate) + (BracketOneCap * BracketOneRate);
                    }
                    else
                    {
                        double taxableIncome = income - BracketTwoCap;
                        return (taxableIncome * BracketThreeRate) + ((BracketTwoCap - BracketOneCap) * BracketTwoRate) + (BracketOneCap * BracketOneRate);

                    }
                }
                else
                {
                    double taxableIncome = income - BracketOneCap;
                    return (taxableIncome * BracketTwoRate) + (BracketOneCap * BracketOneRate);
                }
            }
            else
            {
               return (income * BracketOneRate);
            }
        }
    }
}
