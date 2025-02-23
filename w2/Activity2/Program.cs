﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {
        static void Main (string[] args) {

            //Declare vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;

            Console.WriteLine ("Averager Program: How many week's earning are you going to average?");
            strCntr = Console.ReadLine ();
            intCntr = Int32.Parse (strCntr);

            Double[] dblEarnings = new Double[intCntr];

            Console.WriteLine ("Averager Program: Enter weekly earnings.\n\n");

            //Loop iterates up to the number of weeks that the user put in            
            for (int intCounter = 0; intCounter < intCntr; intCounter++) {
                //While loop to insure the user inputs correct values
                do {
                    Console.Write ("Please enter payroll #" + (intCounter + 1) + ": ");
                    strNum = Console.ReadLine ();

                    blnResult = Double.TryParse (strNum, out dblNum);

                    if (blnResult == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    }
                } while (blnResult == false);
                //Adds to the total if its correct
                dblTotal += dblNum;

            }
            

            //Calculates the average and prints it
            dblResult = Math.Round((dblTotal / intCntr),2);
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult);

            //Last check to see if they want to exit the program
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();

        }
    }
}