using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulateExample
{
    public class University
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            University u = new University();
            u.Name = Console.ReadLine();
            Console.WriteLine(u.Name);


        }

    }
}
