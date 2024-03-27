namespace task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1=new Person("tural","rustemov",20);
            Student student1=new Student("Yusif", "Orucov", 21,"salam123",12);
            person1.ShowFullInfo();
            student1.ShowFullInfo();
        }
    }
}
