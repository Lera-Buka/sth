using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Addres
    {
        public string Country { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public Addres(string country, string district, string street)
        {
            Country = country;
            District = district;
            Street = street;
        }
       
        /*public Addres()
        {
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.Write("District: ");
            district = Console.ReadLine();
            Console.Write("Street: ");
            street = Console.ReadLine();
        }*/
    }
}
