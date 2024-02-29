using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using ConsoleApp.CpSol;
using ConsoleApp.interview;
using System;
using System.Runtime.InteropServices.Marshalling;
namespace ConsoleApp
{
    internal class Person(string name, int age)
    {
        private string Name { get; set; } = name;
        private int Age { get; set; } = age;

        protected virtual void Greet()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Age is {Age}");
        }
    }

    internal class Student(string name, int age, string dept) : Person(name, age)
    {
        private string Dept { get; set; } = dept;

        protected override void Greet()
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
            else if (Size.Equals(4)) Console.WriteLine("This is Square Constructed ");
            else Console.WriteLine("Fu*king Constructed");
        }

        private int Size { get; set; }
    }

    internal class Triangle(int size) : Shape(size);

    abstract class Program
    {
        // public delegate int Math(int x,int y);
        public delegate bool NameFilter(string name);

        public static bool StartWithA(string name) => name.StartsWith("A");

        private static List<string> FilterNames(List<string> names, NameFilter filter)
        {
            List<string> filteredList = new List<string>();
            foreach (string name in names)
            {
                if (filter(name))
                {
                    filteredList.Add(name);
                }
            }

            return filteredList;
        }
        
   
        public static void Main(string[] args)
        {
            //  int[] arr = new[] { 1,1 };
            // // Console.WriteLine(new Solution().SingleNumber(arr));
            // new Solution().FindDisappearedNumbers(arr).ToList().ForEach(System.Console.WriteLine);
            
            TimeSpan timeSpan=new TimeSpan();
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
          //  new Dogs().Speak();
            
            // Console.WriteLine(new PlayWithKeys().GetClassInfo());
            // var student = new Student("Durjoy Acharya", 25, "Software Engineering");
            // student.Greet();
            // new Triangle(5);
            // int num = int.MaxValue;
            // int res =checked(num * 2) ;
            // Console.WriteLine(res);
            // Math add = (int a, int b) => a + b;
            // Console.WriteLine(add(5,3));
            // List<string> names = new List<string> { "Alice","Apu", "Bob", "Charlie", "David" };
            // List<string> filteredNames = FilterNames(names, StartWithA);
            //
            // filteredNames.ForEach(Console.WriteLine);
            // Usage

        }


    }
}

