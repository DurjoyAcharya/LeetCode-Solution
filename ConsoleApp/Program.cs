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

    internal class Student(string name, int age,string dept) :Person(name, age)
    {
        private string Dept { get; set; } = dept;

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine($"Department is {this.Dept}");
        }
    }

    internal class Shape
    {
        protected Shape(int size)
        {
            Size = size;
            if (Size.Equals(3)) Console.WriteLine("This is Triangle Constructed ");
            else if(Size.Equals(4)) Console.WriteLine("This is Square Constructed ");
            else Console.WriteLine("Fu*king Constructed");
        }

        private int Size { get; set; }
    }

    internal class Triangle(int size) : Shape(size);

    abstract class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine(new PlayWithKeys().GetClassInfo());
            // var student = new Student("Durjoy Acharya", 25, "Software Engineering");
            // student.Greet();
            new Triangle(5);



        }
    }
};

