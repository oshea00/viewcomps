using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace viewcomps.Models
{
    public interface ICityRepository
    {
        IEnumerable<City> Cities { get; }
        void AddCity(City city);
    }

    public class MemoryCityRepository : ICityRepository
    {
        List<City> cities = new List<City> {
            new City {Name = "London", Country="UK", Population= 854000},
            new City {Name = "New York", Country="US", Population= 8500000}
        };

        public IEnumerable<City> Cities => cities;

        public void AddCity(City city)
        {
            cities.Add(city);
        }
    }
}
