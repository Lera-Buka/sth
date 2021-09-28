using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Human
    {
        public string name;
        public int age;
        public string gender;
        public Addres address;

        public Human(string newName, int newAge, string newGender, Addres newAddress)
        {
            name = newName;
            age = newAge;
            gender = newGender;
            address = newAddress;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public Addres Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }
        public Human()
        {
            Console.Write("Input name: ");
            name = Console.ReadLine();

            Console.Write("Input age: ");
            string ageStr = age.ToString();
            ageStr = Console.ReadLine();
            int.TryParse(ageStr, out age);

            Console.Write("Input gender: ");
            gender = Console.ReadLine();

            Console.Write("Input address:");
            address = new Addres();

        }
        public void GetInfo()
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age + "\nGender: " + gender);
            address.GetInfo();
        }
    }
}

