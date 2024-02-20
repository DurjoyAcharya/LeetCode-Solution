using ConsoleApp.interview;

namespace ConsoleApp
{
    internal class Person(string name,int age)
    {
        private string Name { get; set; } = name;
        private int Age { get; set; } = age;

        public virtual void Greet()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Age is {Age}");
        }
    }
    
    
    abstract class Program
    {
        
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine(new PlayWithKeys().GetClassInfo());
        }
    }
};

