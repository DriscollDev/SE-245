using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Lab1 {
    class Program {
        //Calculate payroll with Name, hour, hourly rate, along with taxes deducted based on tax bracket.
        static void Main (string[] args) {
            String name="", strHours="", strRate="";
            int intHours=0;
            Double taxRate=0.00,net=0.00, tax=0.00, intRate=0.00, gross=0.00;
            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your name: ");

            name = Console.ReadLine ();

            Console.WriteLine ("Hello " + name + "! Let's do some taxes!");

            Console.Write ("Please enter your hourly pay: ");
            strRate = Console.ReadLine ();

            Console.Write ("Please enter how many hours you have worked: ");
            strHours = Console.ReadLine();

            intHours = int.Parse (strHours);
            intRate = float.Parse (strRate);
            gross = intHours * intRate;
            if(gross > 1000){
                taxRate = 0.5;
            }
            else if(gross > 500){
                taxRate = 0.3;
            }
            else if(gross > 100){
                taxRate = 0.2;
            }
            else{
                taxRate = 0.0;
            }
            tax = taxRate * gross;
            net = gross - tax;

            Console.WriteLine ($"\nYour gross pay is ${Math.round(gross,2)}\nWith a tax of ${Math.round(tax,2)}\nYour net pay is ${Math.round(net,2)}");

            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}