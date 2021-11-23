using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public int counter = 0;
        private TeacherList _teacherList=new TeacherList();
        private  int numberTeacher;
        DataTable Table = new DataTable();
        public void Human_add()
        {
           
            _teacherList.TeacherAdd("Sam", "Ster", 17, "male", "Ukraine", "Lviv", "Stepanska", 20);
            _teacherList.TeacherAdd("Sofi", "Nime", 18, "female", "Ukraine", "Dnipro", "Central", 29);
            _teacherList.TeacherAdd("Nile", "Ster", 17, "male", "Ukraine", "Kyiv", "Vorontsova", 54);
            _teacherList.TeachersList[0].AddStudent("srj", "jgf", 19, "Ukra", "fds", "cxz","kjgh", "A");
            _teacherList.TeachersList[1].AddStudent("srj", "uk", 19, "Ukra", "fds", "cxz", "kjgh", "A");
            _teacherList.TeachersList[2].AddStudent("jfg", "fghc", 19, "Ukrg", "fbv", "bvc", "kcbch", "f");
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable();
            Chart();
            TreeViev();
            Form2.AddStudentInApp += AddStd;
            Form3.AddTeacherInApp += AddTeacher;

        }

        public void DataTable()

        {
            
            DataColumn Name = new DataColumn("Name");
            DataColumn Surname = new DataColumn("Surname");
            DataColumn Age = new DataColumn("Age");
            DataColumn Gender = new DataColumn("Gender");
            DataColumn Country = new DataColumn("Country");
            DataColumn District = new DataColumn("District");
            DataColumn Street = new DataColumn("Street");



            
            Table.Columns.Add(Name);
            Table.Columns.Add(Surname);
            Table.Columns.Add(Age);
            Table.Columns.Add(Gender);
            Table.Columns.Add(Country);
            Table.Columns.Add(District);
            Table.Columns.Add(Street);
          
            this.dataGridView1.DataSource = Table;

        }
        public void GridVievUpd()
        {
            try
            {
                Table.Rows.Clear();
            }
            catch
            {

            }
            finally
            {
                foreach (Teacher teacher in _teacherList.TeachersList)
                {
                    Table.Rows.Add(teacher.Name, teacher.Surname, teacher.Age, teacher.Gender, teacher.Address.Country, teacher.Address.District, teacher.Address.Street);
                }
                this.dataGridView1.DataSource = Table;
            }
           
        }

        private void DataGridVievColor() 
        {   
            int i = 0;
            foreach(Teacher teacher in _teacherList.TeachersList)
            {
                if (teacher.LimitStudentList == teacher.LimitCounter)
                {
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Red;
                }
                else 
                {
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Green;
                }
                i++;
            }
            
            
        }
        private void AddStd(string Name, string Surname, int Age, string Gender, string Country, string District, string Street, string Mark, string Teacher)
        {
            String[] teacher = Teacher.Split(' ');
            int Num = _teacherList.FindTeacher(teacher[0],teacher[1]);
            _teacherList.TeachersList[Num].AddStudent(Name, Surname, Age, Gender, Country, District, Street, Mark);
            GridVievUpd();
            Chart();
            TreeViev();

        }
        private void AddTeacher(string Name, string Surname, int Age, string Gender, string Country, string District, string Street, int LimitCounter)
        {
            _teacherList.TeacherAdd(Name, Surname, Age, Gender, Country, District, Street, LimitCounter);
            GridVievUpd();
            Chart();
            TreeViev();
            DataGridVievColor();

        }
       
        private void Chart()
        {
            for(int i=0; i< _teacherList.TeachersList.Count; i++)
            {
                this.chart1.Series["Age"].Points.AddXY(_teacherList.TeachersList[i].Name, _teacherList.TeachersList[i].Age);
            }
        }

        private void TreeViev()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            TreeNode listTeachers = new TreeNode();
            listTeachers.Name = "list teachers";
            listTeachers.Text = "Teacher list";


            int i = 0;
            foreach (Teacher teacher in _teacherList.TeachersList)
            {
                treeView1.Nodes.Add(teacher.Surname + "  " +teacher.Name);
                treeView1.Nodes[i].Nodes.Add("Students");
                foreach (Student student in teacher.StudentsList)
                {
                    treeView1.Nodes[i].Nodes[0].Nodes.Add(student.Surname + " " + student.Name);
                }
                i++;
            }
                treeView1.EndUpdate();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 TeacherForm= new Form3();
            DialogResult result = TeacherForm.ShowDialog(this);
        }

        private void studebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 StudentForm = new Form2(_teacherList);
            DialogResult result = StudentForm.ShowDialog(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                string name =Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                string surname = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);
                numberTeacher = _teacherList.FindTeacher(surname, name);
                StudentGridView(numberTeacher);
            }
        }
        private void StudentGridView(int num)
        {
            DataTable StudentTable = new DataTable();
            DataColumn Name = new DataColumn("Name");
            DataColumn Surname = new DataColumn("Surname");
            DataColumn Age = new DataColumn("Age");
            DataColumn Gender = new DataColumn("Gender");
            DataColumn Country = new DataColumn("Country");
            DataColumn District = new DataColumn("District");
            DataColumn Street = new DataColumn("Street");
            DataColumn Mark = new DataColumn("Mark");



            StudentTable.Columns.Add(Name);
            StudentTable.Columns.Add(Surname);
            StudentTable.Columns.Add(Age);
            StudentTable.Columns.Add(Gender);
            StudentTable.Columns.Add(Country);
            StudentTable.Columns.Add(District);
            StudentTable.Columns.Add(Street);
            StudentTable.Columns.Add(Mark);

            try
            {
                foreach (Student std in _teacherList.TeachersList[num].StudentsList)
                {
                    StudentTable.Rows.Add(std.Name, std.Surname, std.Age, std.Gender, std.Address.Country, std.Address.District, std.Address.Street);

                }


                this.dataGridView2.DataSource = StudentTable;
            }
            catch 
            {

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox1.Text}%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox2.Text}%'";
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _teacherList.RemoveTeacher(Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
                GridVievUpd();
                Chart();
                TreeViev();
            }
            catch 
            {
                MessageBox.Show("Select teacher");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _teacherList.TeachersList[numberTeacher].RemoveStudent(Convert.ToString(dataGridView2.SelectedRows[0].Cells[1].Value), Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value));
                StudentGridView(numberTeacher);
                Chart();
                TreeViev();
            }
            catch 
            {
                MessageBox.Show("Select studend");
            }

        }

   
        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, _teacherList);
                }
            }
        }

        private void loadJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Text files(*.json,)|*.json;|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _teacherList = JsonConvert.DeserializeObject<TeacherList>(File.ReadAllText(openFileDialog1.FileName));
                GridVievUpd();
                Chart();
                TreeViev();
                DataGridVievColor();
            }
        }
    }
}
