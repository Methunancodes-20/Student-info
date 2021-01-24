
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassObject_assignment
{
    class Program

    // https://www.c-sharpcorner.com/article/a-simple-calculator-class-in-C-Sharp-6/
    {
        /*
        PROGRAMME	: Class Object grade assignment 

            OUTLINE	:	Theres 2 student objects which ask for name, grade, and mark which user inputs then it says who has the higher 
                           mark. Theres error checking telling user if you did something wrong while entering a input in letting you rewrite
                           the name, grade or mark after the error. This uses method, classes, objects, try catch, variables, if statements
                           and libararies to write the code. The way the code works is more better described in the comments letting
                           you know what each line does and down below shows how the ouput of the console should look


            PROGRAMMER	:	Methunan Uthayakumar

            DATE		:	October 13, 2020
        */
        static void Main(string[] args)
        {
            Grade(); // calls the method 
        }

        public static void Grade()
        {
            try
            { // tells to try the codes below 
               
                Console.WriteLine("Student 1: Press enter after inputting "); // writes down student 1
                Console.WriteLine("Input Name: "); // asks for name and declares the variable as string
                String name = Console.ReadLine();
                while (string.IsNullOrEmpty(name) || Regex.IsMatch(name, "^[a-zA-Z]+$") is false)
                {
                    Console.Write("Re enter your name: ");
                    name = Console.ReadLine();
                }

                Console.WriteLine("Input Grade 1-12 : ");
                int grade = 0;  
                while (!Int32.TryParse(Console.ReadLine(), out grade) || grade < 1 || grade > 12)
                {
                    Console.Write("Re Enter grade from 1 to 12: ");   
                }

               
                Console.WriteLine("Input Mark1 1-100 : "); // asks for mark and declares the variable as int
                int mark1 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark1) || mark1 < 0 || mark1 > 100)
                {
                    Console.Write("Re Enter Mark1 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark2 1-100 : "); // asks for mark and declares the variable as int
                int mark2 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark2) || mark2 < 0 || mark2 > 100)
                {
                    Console.Write("Re Enter Mark2 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark3 1-100 : "); // asks for mark and declares the variable as int
                int mark3 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark3) || mark3 < 0 || mark3 > 100)
                {
                    Console.Write("Re Enter Mark3 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark4 1-100 : "); // asks for mark and declares the variable as int
                int mark4 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark4) || mark4 < 0 || mark4 > 100)
                {
                    Console.Write("Re Enter Mark4 from 1 to 100: ");
                }

 
               
                var Mainm = new calculator_class(mark1,mark2,mark3,mark4);
                Console.WriteLine("your Average is " + Mainm.mmark()  + " press enter"); // prints the objects mark
                Console.ReadLine();

                /*
                 basically everything that was up top is now done to the 2nd student option so it is the name code but with variables named 
                two so the inputs error checking all follow the same example as the ones up top 
                 */
                Console.WriteLine("\n Student 2: Press enter after inputting ");
                Console.WriteLine("Input Name: ");
                string name2 = Console.ReadLine();
                while (string.IsNullOrEmpty(name2) || Regex.IsMatch(name2, "^[a-zA-Z]+$") is false)
                {
                    Console.Write("Re enter your name: ");
                    name2 = Console.ReadLine();
                }

                Console.WriteLine("Input Grade 1-12 : ");
                int grade2 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out grade2) || grade2 < 1 || grade2 > 12)
                {
                    Console.Write("Re Enter grade from 1 to 12: ");
                }


                Console.WriteLine("Input Mark1 1-100 : "); // asks for mark and declares the variable as int
                int mark_1 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark_1) || mark_1 < 0 || mark_1 > 100)
                {
                    Console.Write("Re Enter Mark1 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark2 1-100 : "); // asks for mark and declares the variable as int
                int mark_2 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark_2) || mark_2 < 0 || mark_2 > 100)
                {
                    Console.Write("Re Enter Mark2 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark3 1-100 : "); // asks for mark and declares the variable as int
                int mark_3 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark_3) || mark_3 < 0 || mark_3 > 100)
                {
                    Console.Write("Re Enter Mark3 from 1 to 100: ");
                }

                Console.WriteLine("Input Mark4 1-100 : "); // asks for mark and declares the variable as int
                int mark_4 = 0;
                while (!Int32.TryParse(Console.ReadLine(), out mark_4) || mark_4 < 0 || mark_4 > 100)
                {
                    Console.Write("Re Enter Mark4 from 1 to 100: ");
                }

               
                var Mainm1 = new calculator_class(mark_1, mark_2, mark_3, mark_4);
                Console.WriteLine("your Average is " + Mainm1.mmark() + " press enter");
                Console.ReadLine();


                var student1 = new Student(name, grade); // this basically says the student1 is a object and has the student class defines what the variable assigned to make it the student object
                var student2 = new Student(name2, grade2);

                if (Mainm.mmark() == Mainm1.mmark()) // if they have the same mark it says theres mark are the same 
                {
                    Console.WriteLine("\n They have the same Average press enter ");
                    Console.ReadLine();
                }
                else if (Mainm.mmark() > Mainm1.mmark()) // if student 1 is higher then student 2 it says student 1 has the higher mark
                {
                    Console.WriteLine("\n" + student1.name + " Has the higher average compared to " + student2.name + " and is in grade " + student1.grade + "\n Press enter ");
                    Console.ReadLine();
                }
                else // if student 2 is higher then student 1 it says student 2 has the higher mark
                {
                    Console.WriteLine("\n" + student2.name + " Has the higher average compared to " + student1.name + " and is in grade " + student2.grade + "\n Press enter ");
                    Console.ReadLine();
                }

                Console.Write("Type 'Yes' to restart program or 'No' to exit if somthing else is inputted program will close: ");
                string end = Console.ReadLine();

                while (end != "Yes" || end != "No")
                {
                    if (end == "Yes")
                    {
                        Console.Clear(); // clears any text on the console
                        Program.Grade(); // this just restarts the method named grade 
                    }
                    else if (end == "No")
                    {
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.Write("Reenter");
                        end = Console.ReadLine();
                    }
                } 
            }
            catch (Exception) // this catches any errors that may appear in the code which is an exception
            {
                Console.WriteLine("A input you typed in was wrong program will restart: Press Enter "); // displays if theres an error and says it will restart
                Console.ReadLine();
                Console.Clear(); // clears any text on the console
                Program.Grade(); // this just restarts the method named grade 
            }
        }
    }
}
