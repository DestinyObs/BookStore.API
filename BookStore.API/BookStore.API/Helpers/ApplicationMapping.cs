using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Helpers
{
    public class ApplicationMapping : Profile
    {
        public ApplicationMapping()
        {

            CreateMap<Books, BookModel>().ReverseMap();

        }
    }
}
