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
        public Form1()
        {
            InitializeComponent();
            while (counter<5)
            {
                Human_List.Add(new Human());
                counter += 1;
            }
        }
        public void DataTable()

        {
            DataTable Table = new DataTable();
            DataColumn idColumn = new DataColumn("Id");
            idColumn.AutoIncrement = true;
            DataColumn Name = new DataColumn("Name");
            DataColumn Surname = new DataColumn("Surname");
            DataColumn Age = new DataColumn("Age");
            DataColumn Gender = new DataColumn("Gender");
            DataColumn Country = new DataColumn("Country");
            DataColumn District = new DataColumn("District");
            DataColumn Street = new DataColumn("Street");



            Table.Columns.Add(idColumn);
            Table.Columns.Add(Name);
            Table.Columns.Add(Surname);
            Table.Columns.Add(Age);
            Table.Columns.Add(Gender);
            Table.Columns.Add(Country);
            Table.Columns.Add(District);
            Table.Columns.Add(Street);

            while (counter<5)
            {
                Human human = Human_List[counter];
                Table.Rows.Add(new Object[] { idColumn, human.Name, human.Surname, human.Age, human.Gender, human.Address.Country, human.Address.District, human.Address.Street });
                human = null;
                counter += 1;

            }
        }

    }
}
