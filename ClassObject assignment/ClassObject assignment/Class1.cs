using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject_assignment
{
    class Student 
    {
        public string name; // writes the variables as public to be able to access it in the program
        public int grade;   // is just assigning the variables as int and string
       
        public Student(string aName, int aGrade) // defines what the student class should have and were using a constructor so its easier to define variables
        { // defines the variables to the class
            name = aName;
            grade = aGrade;
        }
    }
}
