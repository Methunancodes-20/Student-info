using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject_assignment
{
    class calculator_class
    {
        public int mark1;
        public int mark2;
        public int mark3;
        public int mark4;
      
        public calculator_class(int Mark1, int Mark2, int Mark3, int Mark4) // defines what the student class should have and were using a constructor so its easier to define variables
        { // defines the variables to the class
           
            mark1 = Mark1;
            mark2 = Mark2;
            mark3 = Mark3;
            mark4 = Mark4;
         

            
        }

        public int mmark ()
        {
            return (mark1 + mark2 + mark3 + mark4) /4;
        }
    }
}
