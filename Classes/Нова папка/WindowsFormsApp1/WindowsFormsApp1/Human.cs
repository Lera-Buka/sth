using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  
    
        class Human
        {
            public string name;
            public string surname;
            public int age;
            public string gender;
            public Addres address;

            public Human(string Name,string Surname, int Age, string Gender, Addres Address)
            {
                name = Name;
                surname = Surname;
                age = Age;
                gender = Gender;
                address = Address;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }

            }
            public string Surname
            {
                get { return surname; }
                set { surname = value; }

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

            public string InputName()
            {
                Console.Write("Input name: ");
                name = Console.ReadLine();
                return name;
            }
            public string InputSurname()
            {
                Console.Write("Input surname: ");
                name = Console.ReadLine();
                return surname;
            }
            public int InputAge()
            {
                Console.Write("Input age: ");
                string ageStr = age.ToString();
                ageStr = Console.ReadLine();
                int.TryParse(ageStr, out age);
                return age;
            }
            public string InputGender()
            {
                Console.Write("Input gender: ");
                gender = Console.ReadLine();
                return gender;
            }
            public Addres InputAddres()
            {
                Console.Write("Input address:");
                address = new Addres();
                return address;
            }
            public Human()
            {
                name = InputName();
                age = InputAge();
                gender = InputGender();
                address = InputAddres();
            }
        }
}
