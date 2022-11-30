using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6
{
    //6.1 შექმენით კლასი Employee რომელსაც ექნება სახელი, გვარი, პირადი ნომერი და ხელფასის ველები
    class Employee
    {
        public string First_Name;
        public string Last_Name;
        public string ID_Number;
        public double Salary_Field;

        public Employee()

        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.ID_Number = ID_Number;
            this.Salary_Field = Salary_Field;

            Console.Write("Enter Employee's First_Name :");
            First_Name = Console.ReadLine();
            Console.Write("Enter Employee's Last_Name :");
            Last_Name = Console.ReadLine();
            Console.Write("Enter ID_Number :");
            ID_Number = Console.ReadLine();
            Console.Write("Enter Salary_Field :");
            Salary_Field = double.Parse(Console.ReadLine());


        }
        public void Print()
        {
            Console.Write("\n------------------------------");
            Console.WriteLine("\nYou entered this data:");

            Console.WriteLine("First Name :{0} \nLast Name :{1}\nId :{2}\nSalary_Field: {3} \n", First_Name, Last_Name, ID_Number, Salary_Field);
        }
    }
    class program
    {

        static void Main(string[] args)
        {
            Employee s1 = new Employee();
            s1.Print();
            Console.ReadLine();
        }
    }
}

