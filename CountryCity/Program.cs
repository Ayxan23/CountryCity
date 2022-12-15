namespace CountryCity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // America
            City newYork = new City("New York", 8480000);
            City losAngeles = new City("Los Angeles", 3840000);
            City sanFrancisco = new City("San Francisco", 815000);
            City[] americaCities = { newYork, losAngeles, sanFrancisco };
            
            Country america = new Country("America", americaCities);
            
            america.FindAllByPopulation(100000, 1000000);
            Console.WriteLine(america.TotalPopulation);


            // Russia 
            City moskova = new City("Moskova", 10400000);
            City sanktPeterburg = new City("Sankt Peterburg", 4990000);
            City samara = new City("Samara", 1170000);
            City[] russiaCities = { moskova, sanktPeterburg, samara };

            Country russia = new Country("Russia", russiaCities);

            russia.FindAllByPopulation(100000, 10500000);
            Console.WriteLine(russia.TotalPopulation);

        }
    }
}