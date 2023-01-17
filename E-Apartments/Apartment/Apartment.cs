using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_Apartments.Apartment
{
    internal class Apartment
    {
        public int Id { get; set; }

        public int No { get; set; }

        public string Address { get; set; }
        public int Bedrooms { get; set; }
        public decimal RentPrice { get; set; }

        public Apartment( int no, string address, int bedrooms, decimal rentPrice)
        {
            No = no;
            Address = address;
            Bedrooms = bedrooms;
            RentPrice = rentPrice;
        }


        public int GetBuildingIDFromText(String building_data)
        {
            var match = Regex.Match(building_data, @"Building\s(\d+)");
            int buildingNumber = 0;
            if (match.Success)
            {
                buildingNumber = int.Parse(match.Groups[1].Value);
            }
            return buildingNumber;
        }
    }
}
