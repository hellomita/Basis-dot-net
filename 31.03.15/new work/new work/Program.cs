using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace new_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a > 80 && a < 100)
            //{
            //    Console.WriteLine("Grade is : A+");
            //}
            //else if (a > 70 && a < 79)
            //{
            //    Console.WriteLine("Grade is : A");                       Assignment of Grading System
            //}
            //else if (a > 60 && a < 69)
            //{
            //    Console.WriteLine("Grade is : A-");
            //}
            //else if (a > 50 && a < 59)
            //{
            //    Console.WriteLine("Grade is : B+");
            //}
            //else if (a > 40 && a < 49)
            //{
            //    Console.WriteLine("Grade is : B");
            //}
            //else if (a > 30 && a < 39)
            //{
            //    Console.WriteLine("Grade is : F");
            //}
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(GradeSystem(a));


        //    Console.ReadLine();
        //}





        //static string GradeSystem(int a)
        //{
        //    if (a > 80 && a < 100)
        //    {
        //        return "A+";
        //    }
        //    else if (a > 70 && a < 79)
        //    {
        //        return "A";
        //    }
        //    else if (a > 60 && a < 69)                               class work of grading system using method
        //    {
        //        return "A-";
        //    }
        //    else if (a > 50 && a < 59)
        //    {
        //        return "B+";
        //    }
        //    else if (a > 40 && a < 49)
        //    {
        //        return "B";
        //    }
        //    else if (a > 30 && a < 39)
        //    {
        //        return "F";
        //    }

            int num = 25;

            //while (num < 27)
            //{
            //    Console.WriteLine("Less Than 30");                  /* while loop*/
            //    num +=1;
            //}




            //do
            //{
            //    Console.WriteLine("Less Than 30");                  /* Do While */
            //    num += 1;
            //} while (num < 27);



            //int sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sum = sum + i;
            //    Console.WriteLine(i);             /*for Loop work*/
                

            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();



        //    string[] str = new string[2] {"Hello","World"};
        //    Console.WriteLine(str[2]);

        //    int[] numbers = new int[8];

        //    numbers[1] = 12;
        //    numbers[2] = 14;
        //    numbers[3] = 48;
        //    numbers[4] = 89;
        //    numbers[5] = 45;
        //    Array.Sort(numbers);
        //    Array.Reverse(numbers);

        //    Console.WriteLine(numbers[2]);
        //    Console.WriteLine("Length");+numbers.Length);
        //    for (int i = 0; i < 5; i ++)

        //    {

        //        Console.WriteLine(numbers[i]);
        //        numbers[5] = 100;

        //        foreach (int i = 0; i <)
        //    }





        //}
        //NumberS[5]()= 10;

        //Console.Readkey();

            //### Arraylist: 



            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("SEIP");
            myArrayList.Add(12.5);

            //Console.WriteLine(myArrayList[1]);

            foreach (var VARIABLE in myArrayList)
            {
                Console.WriteLine(VARIABLE);
            }



             ######### List:


            //List<int> myList = new List<int>();
            //myList.Add(4);
            //myList.Add(9);
            //myList.Add(24);

            //myList.Reverse();
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);

            //}
            //List<string> secondList = new List<string>();
            //secondList.Add("BITM");
            //secondList.Add("NERD Castle");

            //foreach (string s in secondList)
            //{
            //    Console.WriteLine();
            //}



            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
            }




            Console.ReadLine();

        }

        }
}
