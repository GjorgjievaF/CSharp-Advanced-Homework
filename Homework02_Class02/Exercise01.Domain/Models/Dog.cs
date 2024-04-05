using Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Dog : Animal, IDog
    {

        public string Owner { get; set; }

        public string Color { get; set; }


        public Dog(string name,string type,int age,string owner,string color) : base(name, type, age)
        {
            Owner = owner;
            Color = color;
        }
        public override void PrintAnimal1()
        {
            Console.WriteLine($"The dog name is {Name} an it is {Age} years old.It is {Type} and {Color} color.The owner name is {Owner}");
        }

        public void Bark()
        {
            Console.WriteLine("Bark,Bark,Bark");
        }
    }
}
