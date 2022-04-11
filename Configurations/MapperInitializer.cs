using AutoMapper;
using Colomb.Data;
using Colomb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Configurations
{
    public class MapperInitializer: Profile
    {
        public MapperInitializer()
        {
            // Define mappings
            // Compte class fields have a direct corelation with CompteDTO fields
            CreateMap<Compte, CompteDTO>().ReverseMap();
            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<Review, CreateReviewDTO>().ReverseMap();
            CreateMap<Evenement, EvenementDTO>().ReverseMap();
            CreateMap<Evenement, CreateEvenementDTO>().ReverseMap();
        }
    }
}
