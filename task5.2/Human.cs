using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public string Gender;
        private int _age;
        public int Age { get { return _age; } set 
            {
                if (value > 0)
                {
                    _age=value;
                    
                }else
                {
                    Console.WriteLine("yas sifirdan boyuk olmalidi");
                }
            } }
        public Human(string name,string surname,string gender,int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;


        }public string Getinfo()
        {
            return(Name+" "+Surname+" "+Gender+" "+Age);
        }
        public void ShowInfo()
        {
            Console.WriteLine(Getinfo());
        }
    }
}
