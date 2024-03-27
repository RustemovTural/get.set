using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2
{
    internal class Doctor:Human
    {
        public string Speciality;
        private int _experience;
        public int Experience { get { return _experience; } set
            {
                if(value>=5) 
                {
                    _experience = value;
                }
                else
                {
                    Console.WriteLine("tecrubenizin kifayet qeder deyil");
                }
            } }
        public Doctor(string name,string surname,string gender,int age,string speciality,int experience):base(name,surname,gender,age)
        {
            Speciality = speciality;
            Experience = experience;
        }public string GetInfo()
        {
            return(Name+" "+Surname+" "+Gender+" "+Age+" "+Speciality+" "+Experience);
            
        }public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
