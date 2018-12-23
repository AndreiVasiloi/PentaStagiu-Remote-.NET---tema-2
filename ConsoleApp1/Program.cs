using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ToUpper()
            Console.WriteLine("1. ToUpper");
            Console.WriteLine();
            string upper = "andrei vasiloi";
            Console.WriteLine("Before");
            Console.WriteLine();
            Console.WriteLine(upper);
            Console.WriteLine();
            Console.WriteLine("After");
            Console.WriteLine();
            Console.WriteLine(upper.ToUpper());
            Console.WriteLine();

            Console.ReadLine();
            //2. IsNullOrEmpty
            Console.WriteLine("2. IsNullOrEmpty");
            Console.WriteLine();
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();


            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You have to tell me your name.");
            }
            else
            {
                Console.WriteLine("Hello {0}", name);
            }
            Console.WriteLine();
            Console.ReadLine();

            //3. Replace
            Console.WriteLine("3. Replace");
            Console.WriteLine();
            Console.WriteLine("Before");
            Console.WriteLine();
            const string laptop = "I have a laptop";
            Console.WriteLine(laptop);
            Console.WriteLine();
            string computer = laptop.Replace("laptop", "computer ");
            Console.WriteLine("After");
            Console.WriteLine();
            Console.WriteLine(computer);
            Console.ReadLine();

            //4. Concat
            Console.WriteLine();
            Console.WriteLine("4. Concat");
            Console.WriteLine();
            string firstName = "Andrei";
            string lastName = "Vasiloi";
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Before");
            Console.WriteLine();
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine();
            Console.WriteLine("After");
            Console.WriteLine(fullName);
            Console.WriteLine();
            Console.ReadLine();

            //5. StartsWith
            Console.WriteLine("5. StartsWith");
            Console.WriteLine();
            string input = "Andrei";

            if (input.StartsWith("A"))
            {
                Console.WriteLine("The string starts with A");
            }
            else
            {
                Console.WriteLine("The string don`t start with A");
            }

            Console.ReadLine();

            //6. Trim
            Console.WriteLine("6. Trim");
            Console.WriteLine();
            string st = "      Andrei Vasiloi       ";
            Console.WriteLine("Before");
            Console.WriteLine();
            Console.WriteLine(st);
            Console.WriteLine();
            st = st.Trim();
            Console.WriteLine("After");
            Console.WriteLine();
            Console.WriteLine(st);
            Console.ReadLine();

            //7. IndexOf
            Console.WriteLine("7. IndexOf");
            Console.WriteLine();
            const string value = "Andrei Vasiloi";

            if (value.IndexOf("Andrei") != -1)
            {
                Console.WriteLine("string contains Andrei!");
            }
            else
            {
                Console.WriteLine("string is not containing Andrei");
            }


            Console.ReadLine();
        }
    }
}
