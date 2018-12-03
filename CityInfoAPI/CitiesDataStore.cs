using CityInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "Lorme ipsum, lorem ipsum and lorem ipsum.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum." 
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum."
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "Lorme ipsum, lorem ipsum and lorem ipsum.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum."
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 3,
                    Name = "Sydney",
                    Description = "Lorme ipsum, lorem ipsum and lorem ipsum.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Lorme ipsum, lorem ipsum and lorem ipsum."
                        }
                    }
                }
            };

        }
    }
}
