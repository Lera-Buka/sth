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
    public partial class Form1 : Form
    {
        private List<Human> Human_List = new List<Human> { };
        public int counter = 0;

        public void Human_add()
        {
            Human human1 = new Human("Nile", "Ster", 17, "male", new Addres( "Ukraine", "Kyiv", "Vorontsova"));
            Human human2 = new Human("Sofi", "Nime", 18, "female", new Addres("Ukraine", "Dnipro", "Central"));
            Human human3 = new Human("Sam", "Ster", 17, "male", new Addres("Ukraine", "Lviv", "Stepanska"));
            Human_List.Add(human1);
            Human_List.Add(human2);
            Human_List.Add(human3);
            

        }
        public Form1()
        {
            InitializeComponent();
            
              
            
        }
        public void DataTable()

        {
            DataTable Table = new DataTable();
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
            Human_add();
            int Counter = Human_List.Count;
            int i = 0;
            while (i<Counter)
            {
               
                Table.Rows.Add(Human_List[i].Name, Human_List[i].Surname, Human_List[i].Age, Human_List[i].Gender, Human_List[i].Address.Country, Human_List[i].Address.District, Human_List[i].Address.Street);
                i++;

            }
            this.dataGridView1.DataSource = Table;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable();
            Chart();
        }
        private void Chart()
        {
            for(int i=0; i<Human_List.Count; i++)
            {
                this.chart1.Series["Age"].Points.AddXY(Human_List[i].Name, Human_List[i].Age);
            }
        }

        private void TreeViev()
        {

        }

    }
}
