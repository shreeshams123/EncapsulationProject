using System;

namespace EncapsulateExample
{
    public class Demo
    {
        private string location;
        public Demo(string name)
        {
            Name = name;
        }
        public string Name
        {
            get => location;
            set => location = value;
        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            Demo d = new Demo("Bangalore");
            Console.WriteLine(d.Name);
        }
    }
}
