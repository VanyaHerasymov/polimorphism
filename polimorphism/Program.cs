using polimorphism;
using System.ComponentModel;

namespace polimorfizm_app
{
    /*public class Animal// Base
                       {     
        public string Name { get; set; }    
        public Animal(string name)    
        {     
            Name = name; 
        } 
        public virtual void Speak()    
        {   
            Console.WriteLine($"{Name} is speaking ...");    
        }   
        public override string ToString()    
        {         
            return $"Name: {Name}"; 
        }   
    } 
    public class Dog : Animal 
    {  
        public int Age { get; set; }     
        public Dog(string name, int age) : base(name)     
        {      
            Age = age;   
        } 
        public override void Speak()     
        {  
            Console.WriteLine($"Dog is speaking ...");      
        }   
        public override string ToString()            => base.ToString() + $", Age: {Age}";    } 
    public class Cat : Animal    {        public int Age { get; set; }  
        public string[] Properties { get; set; }      
        public Cat(string name, int age, string[] properties) : base(name)   
        {            Age = age;            Properties = properties;        }     
        public override void Speak()        {            base.Speak();        }      
        public override string ToString()        {            string result = base.ToString() + "\n";   
            foreach (string property in Properties)            {                result += property + "\t";            }           
            return (result + "\n");    
        }    }*/
    public class Program
    {
        static void Main(string[] args)
        {
            /*    Animal animal = new Animal("Some animal");      
                Console.WriteLine(animal);      
                Dog dog = new Dog("Alex", 14);        
                Console.WriteLine(dog);       
                Cat cat = new Cat("Bob", 7, new string[] { "4 laps", "tail", "head" });  
                Console.WriteLine(cat);      */
            
            Matrix m1=new SquareMatrix(5,5);
            Matrix m2=new SquareMatrix(5,5);
            Matrix m3 = m1.Add(m2);
            m1.PrintMatrix();
            Console.WriteLine("-0----------------");
            m2.PrintMatrix();
            Console.WriteLine("---------------------");
            m3.PrintMatrix();


        }





    }
}





