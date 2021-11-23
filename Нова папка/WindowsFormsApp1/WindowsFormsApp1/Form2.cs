using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private TeacherList tList;
        public delegate  void AddStudent(string Name, string Surname, int Age, string Gender, string Country, string District, string Street,string Mark, string Teacher);
        public static event AddStudent AddStudentInApp;
        public Form2(TeacherList _teacherList)
        {
            InitializeComponent();
            tList= _teacherList;
            InitialCombobox1();
            InitialCombobox2();
        }
        public void InitialCombobox1()
        {
            comboBox1.Items.Add(Marks.S);
            comboBox1.Items.Add(Marks.A);
            comboBox1.Items.Add(Marks.B);
            comboBox1.Items.Add(Marks.C);
            comboBox1.Items.Add(Marks.D);
            comboBox1.Items.Add(Marks.F);
        }
        public void InitialCombobox2()
        {
            foreach(Teacher teach  in tList.TeachersList)
            {
                comboBox2.Items.Add(teach.Surname + " " + teach.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentInApp?.Invoke(namebox.Text, surnamebox.Text, Convert.ToInt32(agebox.Text), genderbox.Text, countrybox.Text, districtbox.Text, streetbox.Text, Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox2.SelectedItem));
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
