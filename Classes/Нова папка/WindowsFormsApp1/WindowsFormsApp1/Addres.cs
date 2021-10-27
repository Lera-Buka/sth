using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Addres
    {
        public string country;
        public string district;
        public string street;
        public Addres(string newCountry, string newDistrict, string newStreet)
        {
            country = newCountry;
            district = newDistrict;
            street = newStreet;
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string District
        {
            get
            {
                return district;
            }
            set
            {
                district = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public Addres()
        {
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.Write("District: ");
            district = Console.ReadLine();
            Console.Write("Street: ");
            street = Console.ReadLine();
        }
}
