using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    class Calculator
    {
        public int first;
        public int second;
        public int result;



        public double AddCalculation()
        {
            result = first + second;
            return result;

        }
        public double SubstractCalculation()
        {
            result = first - second;
            return result;

        }
        public double MultiCalculation()
        {
            result = first * second;
            return result;

        }
        public double DivideCalculation()
        {
            result = first / second;
            return result;

        }
    }
}
