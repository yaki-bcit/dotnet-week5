using Microsoft.EntityFrameworkCore;
using Week_5.Models;

public static class SampleData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
                new Province()
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province()
                {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province()
                {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan"
                }
            };
            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>()
            {
                new City()
                {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 2135000,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 2,
                    CityName = "Victoria",
                    Population = 316000,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 3,
                    CityName = "Kelowna",
                    Population = 141000,
                    ProvinceCode = "BC"
                },
                new City()
                {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 1239000,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId= 5,
                    CityName = "Edmonton",
                    Population = 1321000,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 100000,
                    ProvinceCode = "AB"
                },
                new City()
                {
                    CityId = 7,
                    CityName = "Regina",
                    Population = 180000,
                    ProvinceCode = "SK"
                },
                new City()
                {
                    CityId = 8,
                    CityName = "Saskatoon",
                    Population = 256000,
                    ProvinceCode = "SK"
                },
                new City()
                {
                    CityId = 9,
                    CityName = "Prince Albert",
                    Population = 33000,
                    ProvinceCode = "SK"
                },
            };
            return cities;
        }
    }