using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student:Human
    {
        public string marks { get; set; }
        public Student(string name, string surname, int age, string gender, Addres address, string marks)
            :base (name, surname, age, gender, address)
        {
            this.marks = marks;
        }

    }
}
