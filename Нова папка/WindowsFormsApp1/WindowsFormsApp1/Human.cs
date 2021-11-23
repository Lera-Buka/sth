using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
        public class Human
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public Addres Address { get; set; }

            public Human(string name,string surname, int age, string gender, Addres address)
            {
                Name = name;
                Surname = surname;
                this.Age = age;
                Gender = gender;
                Address = address;
            }
           
            
            
            

           /* public string InputName()
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
           */
        }
}
