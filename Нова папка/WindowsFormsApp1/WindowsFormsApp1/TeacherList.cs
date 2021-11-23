using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TeacherList
    {
        private List<Teacher> teachersList = new List<Teacher>();

        public List<Teacher> TeachersList
        {
            get
            {
                return teachersList;
            }
        }


        public void TeacherAdd( string name, string surname, int age, string gender, string country, string district,  string street,  int studentLimit)
        {
            teachersList.Add(new Teacher( name, surname, age, gender, new Addres(country, district, street), studentLimit));
        }

        public void RemoveTeacher(string surname, string name)
        {

            foreach (Teacher teachers in TeachersList)
            {
                if (surname == teachers.Surname && name == teachers.Name)
                {
                    TeachersList.RemoveAt(TeachersList.IndexOf(teachers));
                    break;
                }
            }
        }



        public int FindTeacher(string surname, string name)
        {
            foreach (Teacher teacher in teachersList)
            {
                if (surname == teacher.Surname && name == teacher.Name)
                {
                    return teachersList.IndexOf(teacher);
                }
            }

            return -1;
        }
    }
}
