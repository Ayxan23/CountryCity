using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCity
{
    internal class City
    {
        public string Name;
        public int Population;

        public City(string name, int populatoin)
        {
            Name = name;
            Population = populatoin;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
