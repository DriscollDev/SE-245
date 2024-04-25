using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Samplel {
    // This is a single line remark or comment (Two forward-slashes) 

    /*

    * This is a multi-line

    * comment.

    * Because these lines are between the open and close

    */

    /*
    Conor Driscoll & Allison Wisher

    1: The program is a calculator that starts off with initializing all the variables needed, then asks for input on name, what calculation type you want to do and the numbers. Then it calculates and prints the final result in a formatted string.

    2: The goal of the program is to calculate simple 2 input math.

    3: The MULTIPLY option is ignored, and not implemented at all.

    4: Will the $"" string act as a formatted string, because in JS it needs `` to work. And is the input case-sensitive?
    */
    class Program {
        static void Main (string[] args) {
            String strFirst, strOperand,strNum1, strNum2;
            int intNum1 = 0, intNum2 = 0, intResult = 0;
            Double dblResult = 0;

            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();

            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE, POWER): ");
            strOperand = Console.ReadLine().ToUpper();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();

            intNum1 = int.Parse (strNum1);
            intNum2 = int.Parse (strNum2);

            switch (strOperand) {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
                case "POWER":
                    dblResult = Math.Pow(intNum1, intNum2);
                    break;
            }
            if(intResult!=0){
                dblResult = (Double) intResult;
            }
            
            switch (strOperand){
                case "PLUS":
                    Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "MINUS":
                    Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "DIVIDE":
                    Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "MULTIPLY":
                    Console.WriteLine ($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "POWER":
                    Console.WriteLine ($"\n\nThe result of {intNum1} raised to the power of {intNum2} is: {dblResult}");
                    break;
            }

            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}