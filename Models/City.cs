using System.Collections.Generic;

namespace CityProvinceLab.Models
{
    public class City
    {
        public int CityId{ get; set; }
        
        public string CityName{ get; set; }
        
        public int Population{ get; set; }

        //foreign key
        public string ProvinceName{ get; set; }
        public Province Province{ get; set; }

        public static List<City> GetCities () {
            List<City> cities = new List<City> () {
            new City {
            CityId = 1,
            CityName = "Vancouver",
            Population = 2000000,
            ProvinceName = "British Columbia",
            },
            new City {
            CityId = 2,
            CityName = "Calgary",
            Population = 2000000,
            ProvinceName = "Alberta",
            },
            new City {
            CityId = 3,
            CityName = "London",
            Population = 2000000,
            ProvinceName = "Ontario",
            },
        };

        return cities;
        }

    }
}