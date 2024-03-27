using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._1
{
    internal class Student:Person
    {
        public string StudentId;
        private double _point;
        public double Point { get { return _point; } set 
            {
                if (value > 0 && value < 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("deyer qebul olunmur");
                }
            } }
        public Student(string name,string surname,int age,string studentid,double point):base(name,surname,age)
        {
            StudentId = studentid;
            Point = point;
        }public void ShowFullInfo()
        {
            Console.WriteLine( Name+" "+ Surname+" "+ Age +","+ StudentId+"," + Point);
        }
    }
}
