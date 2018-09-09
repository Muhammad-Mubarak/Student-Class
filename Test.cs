using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Lab_1
{
    class Test
    {
        /* 
         * This is main function in class test.cs. 
         <summary> In this class we are accessing all attributes of class student that we have written in namespace program.cs
         
            </summary> */
       static void Main()
        {
            int counter = 0;
           
            
                while (counter <=1)
                {
                    /* creating an instance to access class student's data members */
                    student new_student = new student();
                    //accessing student data's input functions through invoking object called name_student//

                    new_student.input();
                    new_student.tostring();

                    //here we triede to access constructors of the class student by creating two objects names " new_var" and " new_var1"//
                    var new_var = new student();      // objects accesing constructors of the class student;
                    var new_var_2 = new student(new_student.Student_name, new_student.Registration_number);
                counter++;

                }
            
            ConsoleKeyInfo info = Console.ReadKey(true);
            if(info.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
                

            


        }




    }
}
