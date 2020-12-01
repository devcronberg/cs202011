using System;

namespace AttribDemo
{
    
    
    class Program
    {
        static void Main([Table("Person")]  string[] args)
        {
            Test();
        }

        
        
        
        [Obsolete("kjhkjhkjh", true)]
        static void Test() {
            Console.WriteLine("Hello World!");
        }
    }
}
