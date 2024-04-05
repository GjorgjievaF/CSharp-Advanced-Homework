using Exercise01.Domain.Interfaces;

namespace Exercise01.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }


        public Animal(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }


        public abstract void PrintAnimal1();
        
        
        public void PrintAnimal()
        {
            Console.WriteLine($"The animal name is {Name} and it is {Type}, {Age} years old.");
        }
    }
}
