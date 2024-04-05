using Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Cat : Animal , ICat
    {
        public bool Lazy { get; set; }
        

        public Cat (string name,string type,int age,bool lazy,string food) : base(name, type, age)
        {
            Lazy = lazy;
           
        }
        
        public override void PrintAnimal1()
        {
            
            string lazy = !Lazy ? "cat is oka" : "cat is crazy";
            Console.WriteLine($"The animal name is {Name} and it is {Type}, {Age} years old.The {lazy}");
        }

        public void Eat()
        {
            
            Console.WriteLine("The cat is always hungry");
        }

       
    }
}
