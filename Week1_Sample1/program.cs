using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strfirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;

            Console.WriteLine("Hello There!");

            Console.Write("Please enter your name: ");
            strfirst = Console.ReadLine();

            Console.WriteLine("Hello " + strfirst + "! Let's do some math!");
            
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine();

            Console.Write("Please Enter the second number: ");
            strNum2 = Console.ReadLine();

            intNum1 = Int32.Parse(strNum1);

            intNum2 = Convert.ToInt32(strNum2);


            switch (strOperand)
            {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
            }

            dblResult = (Double)intResult;

            if(strOperand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            if(strOperand == "MINUS")
            {
                Console.WriteLine($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            }
            if(strOperand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            }
            if(strOperand == "MULTIPLY")
            {
                Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
            }

            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}