using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int firstNumber = 97;
            double secondNumber = firstNumber;
            int thirdNumber = (int)secondNumber;
            char firstChar = Convert.ToChar(firstNumber);
            Console.WriteLine(firstNumber);
            //Console.WriteLine(firstNumber);

            Console.ReadKey();*/
           
            //string message = GetValue();
            //Console.WriteLine(message);
            //Console.WriteLine(CalculateValue(200, 10));
            //Console.WriteLine(MultipleValue(2, 10));
            //Console.WriteLine(DivideValue(10, 2));
            //Console.WriteLine(user());
            // Console.WriteLine(Perimeter(9));
            // Console.WriteLine(area(5));


            //Console.ReadKey();

            int aNumber = 25;
            int bNumber = 30;
            if (aNumber == bNumber)
            {
                Console.WriteLine("Equal");

            }
            //if (aNumber < 20)
            //{
            //    Console.WriteLine("less than 20");
            //}
            //else if (aNumber < 30)
            //{
            //    Console.WriteLine("Less than 30");

            //}
            //else
            //{
            //    Console.WriteLine("Greater than 30");
            //}

            //Console.ReadLine();

        }
        

        static string GetValue()

        {
            return "Hello World";
        }

         static int CalculateValue(int firstNumber, int secondnumber)
        {
            int result = firstNumber + secondnumber;
            return result;

        }

         static int MultipleValue(int firstNumber, int secondnumber)
         {
             int Multi = firstNumber*secondnumber;
             return Multi;
         }
         static int DivideValue(int firstNumber, int secondnumber)
         {
             int Divide = firstNumber / secondnumber;
             return Divide;
         }

         static int user()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int div = a/b;

            return div;

        }

         static  double Perimeter( double r)
         {
             double Perimeter = 2*Math.PI*r;

             return Perimeter;
         }

        private static double area(double b)
        {
            double area = b*b*Math.PI;
            return area;
        }



    }
}
