using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace task5._1
{
    internal class Person
    {
        public string Name;
        public string Surname;
        private int _age;
        public int Age 
        { get
            {
                return _age;
            }
         set
            { 
                if(value>0)
                {
                    _age = value;
                }else
                {
                    Console.WriteLine("yas menfi qebul olunmur");
                }
            }
            }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }public void ShowFullInfo()
        {
            Console.WriteLine(Name+" "+Surname+" "+Age);
        }
    }
}
