﻿using AutoMapper;
using SmallTax.Data.Entities;
using SmallTax.Data.Models;
using SmallTax.ViewModels;

namespace SmallTax.Data
{
    public class TaxMappingProfile : Profile
    {
        public TaxMappingProfile()
        {
            CreateMap<TaxBracket, TaxBracketViewModel>().ReverseMap();
        }
    }
}