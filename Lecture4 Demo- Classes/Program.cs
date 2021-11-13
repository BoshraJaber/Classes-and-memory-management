using System;
using Lecture4_Demo__Classes.Classes;
// I need to import it because it is a different namespace

namespace Lecture4_Demo__Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a new car of type class Car
            // mazda is on the stack
            // new Car() is on the heap
            Car mazda = new Car();
            // what actually happens is that C# calls Car.Make.set("mazda")
            mazda.Make = "mazda";
            mazda.Color = "brown";
            // what actually happens is that C# calls Car.Make.get()
            Console.WriteLine(mazda.Make);
            Console.WriteLine(mazda.Color);

            // another way of creating an instance:
            Car mozda2 = new Car()
            {
                Make = "Ford",
                Color = "Black"
            };

            // third way: It will call the second construtor 
            Car mazda3 = new Car("Ford3", "green", 3);
        }
    }
}
