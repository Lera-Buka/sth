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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        public delegate void AddTeacher(string Name, string Surname, int Age, string Gender, string Country, string District, string Street, int LimitCounter);
        public static event AddTeacher AddTeacherInApp;
        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacherInApp?.Invoke(namebox.Text, surnamebox.Text, Convert.ToInt32(agebox.Text), genderbox.Text, countrybox.Text, districtbox.Text, streetbox.Text, Convert.ToInt32(Limitcounterbox.Text));
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
