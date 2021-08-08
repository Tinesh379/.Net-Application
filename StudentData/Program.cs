using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class  Student
    {
        string _fn;
        string _ln;
        int _roll;
        string _Section;
        string clg;
       
        public Student(string CollegeName)
        {
            this.clg = CollegeName;
        }

        public void stdName( string FN, string LN)
        {
            this._fn = FN;
            this._ln = LN;
        }
        public void stdRoll(int n, string Section)
        {
            this._roll = n;
            this._Section = Section;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Full Name={0}", _fn + _ln);
            Console.WriteLine("Roll Number={0}", _roll);
            Console.WriteLine("Section ={0}", _Section);
            Console.WriteLine("College ={0}", clg + "junior College");
        }
        ~Student()
        {
            //Clears the memory
            //garbage collection
        }

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter College Name");
           
            Student std = new Student(Console.ReadLine());
            Console.WriteLine("Enter first name and last name:");
            std.stdName(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Enter Roll Number & section:");
            std.stdRoll(int.Parse(Console.ReadLine()),Console.ReadLine());
            std.PrintDetails();
            Console.ReadKey();

        }
    }
}
