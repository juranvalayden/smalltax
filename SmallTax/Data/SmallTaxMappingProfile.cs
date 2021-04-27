using AutoMapper;
using SmallTax.Data.Entities;
using SmallTax.ViewModels;

namespace SmallTax.Data
{
    public class SmallTaxMappingProfile : Profile
    {
        public SmallTaxMappingProfile()
        {
            CreateMap<TaxBracket, TaxBracketViewModel>().ReverseMap();
            CreateMap<Person, PersonViewModel>().ReverseMap();
        }
    }
}