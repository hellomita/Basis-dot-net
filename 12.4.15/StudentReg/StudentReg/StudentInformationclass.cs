using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReg
{
    class StudentInformationclass
    {
        public string regNo;
        public string firstName;
        public string lastName;

        public string GetFullName()
        {
            return firstName+""+lastName; 
        }
    }
}
