using System;

namespace AttribDemo
{
    
    
    class Program
    {
        static void Main(  string[] args)
        {
            
        }

        
        
        
        [Obsolete("kjhkjhkjh", true)]
        static void Test() {
            Console.WriteLine("Hello World!");
        }
    }
}
