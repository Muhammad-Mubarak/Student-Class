using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;
namespace SE_Lab_1
{
    /* <summary>
     * we created a class named student in namespace SE_LAB_1,our main focus in this class wass just to create some data members and put some constarints on them according to our requirements </summary> */
    class student 
    {
        private string student_name;
        private string registration_number;
        private DateTime date;
        private double cgpa;
        private string cnic;
        private string[] hobbies;

        //Getters and setters are completeing here.......
        public string Student_name
        {
            get
            {
                return student_name;
            }

            set
            {
                student_name = value;
            }
        }

        public string Registration_number
        {
            get
            {
                return registration_number;
            }

            set
            {
                registration_number = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public double Cgpa
        {
            get
            {
                return cgpa;
            }

            set
            {
                cgpa = value;
            }
        }

        public string Cnic
        {
            get
            {
                return cnic;
            }

            set
            {
                cnic = value;
            }
        }

        public string[] Hobbies
        {
            get
            {
                return hobbies;
            }

            set
            {
                hobbies = value;
            }
        }

        //constructor without  parameters 
        public student()
        {
            
        }
        
        //constructor with two parameters name and registration number;
        public student(string student_name,string registration_number) //constructor with parameters;
            {
            this.student_name = student_name;
            this.registration_number = registration_number;
            }


        //here our first function which is just for taking input from users;
        public void input()
        {
            Console.WriteLine("Enter a Name :");
            this.student_name = Console.ReadLine();

            bool checker = false;
            bool loopBreak = false; //took as a flag holder

            while (checker == false)
            {

                foreach (char letter in student_name)
                {
                    if (char.IsNumber(letter) == true || char.IsSymbol(letter) == true)
                    {
                        loopBreak = true;
                        break;
                    }
                }

                if (loopBreak)
                {
                    loopBreak = false;
                    Console.WriteLine("You can only use alphabets");
                    Console.WriteLine("Enter a Name :");
                    this.student_name = Console.ReadLine();
                    checker = false;
                }

                else
                {
                    checker = true;
                }

            }

            //input for registration number;
            Console.WriteLine("Enter Registration Number");
            this.registration_number = Console.ReadLine();

            //input for date;
            Console.WriteLine("Enter Date of Birth");
            this.date = DateTime.Parse(Console.ReadLine());

            bool checker_date = false;   //as a flag ;
            while (checker_date == false)
            {
                if (date < DateTime.Parse("1-1-2005") && date > DateTime.Parse("31-12-1990"))

                {
                    checker_date = true;

                }

                else
                {
                    Console.WriteLine("Invalid date entered check it again");
                    this.date = DateTime.Parse(Console.ReadLine());
                }

            }
            // here comes input for gpa;
            Console.WriteLine("Enter student's CGPA :");
            this.cgpa = double.Parse(Console.ReadLine());

            bool checker_gpa = false; // ass a flag for loop ;
            while (checker_gpa == false)
            {
                if (Cgpa > 0.0 && cgpa < 4.0)
                {
                    checker_gpa = true;
                }
                else
                {
                    Console.WriteLine("Invalid CGPA :");
                    Console.WriteLine("Enter CGPA again :");
                    this.cgpa = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter your CNIC :");
            this.cnic = Console.ReadLine();
            bool checker_cnic = false;

            while (checker_cnic == false)
            {

                if (cnic.Length == 13)
                {
                    checker_cnic = true;
                }

                else
                {
                    Console.WriteLine("Enter your CNIC :");
                    this.cnic = Console.ReadLine();
                }

            }

            Console.Write("Enter your Hobbies :");
            string[] hobbies = new string[2]; // creating an instnce as null exception was occurring without it because it is a string array;

            for (int counter = 0; counter < hobbies.Length; counter ++)
            {
      
                hobbies[counter] = Console.ReadLine();
            }
        
        }

//for getting age upto current date
        public string GetAge()
        {
            return null;
        }
//gpa status according to result we could not use switch statement bcz it was for bool ;
        public string getStatus()
        {
            string result = null;
            if (this.cgpa < 2.0)
            {
               result = "Suspended";
            }
            else if (this.cgpa > 2.0 || this.cgpa <= 2.5)
            {
                result= "Below Average";
            }
            else if (this.cgpa > 2.5 || this.cgpa <= 3.3)
            {
                result = "Average";
            }
            else if (this.cgpa > 3.3 || this.cgpa <= 3.5)
            {
                result ="Below Good";
            }
            else if (this.cgpa >= 3.5 && this.cgpa <= 4.0)
            {
                result = "Excellent";
            }
            return result;
         }
//calculationg number of total words in string;
        public int number_of_words_in_name()
        {
            string str = this.student_name;
            int word = 1;
            int loop = 0;

            while (loop < str.Length -1)
            {
                if(str[loop] == ' ' || str[loop] == '\t' || str[loop] == '\n')
                {
                    word++;
                }
                loop++;
            }
           
            return word;
        }
        //getting gender by specific rule;
        public string get_gender()
        {
            string result = null;
            int counter = 0;
            string Cnic = this.cnic;
            foreach (char digit in Cnic)
                {
                    counter++;
                    if (counter == 13)
                    {
                        if (digit % 2 != 0)
                        {
                            result = "Male";
                        }
                        else
                        {
                            result = "Female";
                        }
                    }
                }
            return result;
        }

//displaying final output;
        public void tostring()
        {

           
            Console.WriteLine("Name" + ":" + this.student_name +" " + " (" + " Contains" + number_of_words_in_name() + " words" + ")");
            Console.WriteLine("Registration Number" + ":" + this.registration_number);
            Console.WriteLine("CGPA" + ":"+ this.cgpa +" " + getStatus());
            Console.WriteLine("DOB"+":" + this.date);
            Console.WriteLine("CNIC" + ":" + this.cnic);
            Console.WriteLine("Gender " + " :" + get_gender());
            Console.WriteLine("Hobbies" + ":" + hobbies);
        }

//destructor;
        ~student()
        {
            Console.WriteLine("Destructor is called");
        }
      
       }
}
