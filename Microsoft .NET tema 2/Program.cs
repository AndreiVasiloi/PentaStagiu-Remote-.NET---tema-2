using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.NET_tema_2
{
    public enum Gender {
        Male,
        Female
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Can you tell me your year of birth please?");
            string year = Console.ReadLine();
            Console.WriteLine("And the month?");
            string month = Console.ReadLine();
            Console.WriteLine("The day of birth?");
            string day = Console.ReadLine();
            Console.WriteLine("What gender you have (m/f)?");
            string gender = Console.ReadLine();
            gender = gender.ToLower();
            Gender? nullableGender = null;
            if (gender == "m")
            {
                nullableGender = Gender.Male;
            }

            if (gender == "f")
            {
                nullableGender = Gender.Female;
            }


            string dateOfBirth = year + " " + month + " " + day;

            DateTime value = DateTime.Parse(dateOfBirth);
            var now = DateTime.Now;

            TimeSpan diff = now - value;
            int age = (int)(diff.TotalDays / 365);

            int ageOfRetirementMale = 65;
            int ageOfRetirementFemale = 63;

            if (nullableGender == null)
            {
                return;
            }

            int ageOfRetirement = nullableGender == Gender.Male ? ageOfRetirementMale : ageOfRetirementFemale;

            if (age < ageOfRetirement)
            {
                Console.WriteLine("You have to work until retirement " + (ageOfRetirement - age) + " more years.");
            }

            if (age >= ageOfRetirement)
            {
                Console.WriteLine("You are retired!!!");
            }





            Console.ReadLine();
        }
    }
}
