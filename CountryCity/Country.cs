using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCity
{
    internal class Country
    {
        public string Name;
        public int TotalPopulation;
        City[] _cities;

        public Country(string name, City[] cities)
        {
            _cities = cities;
            Name = name;
            TotalPopulation = FindTotalPopulation();
        }


        public void FindAllByPopulation(int min, int max)
        {
            bool result = false;
            foreach (City city in _cities)
            {
                if (city.Population > min && city.Population < max)
                {
                    Console.WriteLine(city);
                    result = true;
                }
            }
            if (result == false)
            {
                Console.WriteLine("Bu ehali araliqinda seher yoxdur!");
            }
        }


        int FindTotalPopulation()
        {
            int result = 0;
            foreach (City city in _cities)
            {
                result += city.Population;
            }
            TotalPopulation = result;
            return TotalPopulation;
        }

    }
}
