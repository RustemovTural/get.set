namespace task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("tural", "rustemov","kisi",20);
            Doctor doctor1 = new Doctor("sadiq", "meherremli", "kisi", 25, "qulaqhekimi",5);
            human1.ShowInfo();
            doctor1.ShowInfo();
            
        }
    }
}
