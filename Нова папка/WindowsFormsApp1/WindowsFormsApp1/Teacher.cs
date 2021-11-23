using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Teacher: Human
    {
        private List<Student> _studentList = new List<Student>();
        private int _limitCounter = 0;
        public int LimitStudentList { get; set; }

        public List<Student> StudentsList
        {
            get
            {
                return _studentList;
            }
        }

        public int LimitCounter
        {
            get
            {
                return _limitCounter;
            }
        }

        public Teacher(string name, string surname, int age, string gender, Addres address, int limitStudents)
           : base(name, surname, age, gender, address)
        {
            LimitStudentList = limitStudents; 
        }

        public void AddStudent(string name, string surname, int age, string gender, string country, string district, string street, string marks)
        {
            _studentList.Add(new Student( name, surname, age, gender, new Addres(country, district,  street), marks));
            _limitCounter++;
        }

        public void RemoveStudent(string surname, string name)
        {
            
            foreach (Student students in _studentList)
            {
                if (surname == students.Surname && name == students.Name)
                {
                    _studentList.RemoveAt(_studentList.IndexOf(students));
                    break;
                }
            }
        }

        public int FindStudent(string surname, string name)
        {
            foreach (Student students in _studentList)
            {
                if (surname == students.Surname && name == students.Name)
                {
                    return _studentList.IndexOf(students);
                }
            }

            return -1;
        }
        
    }
}
