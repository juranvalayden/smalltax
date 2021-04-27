using AutoMapper;
using SmallTax.Data.Entities;
using SmallTax.ViewModels;

namespace SmallTax.Data
{
    public class TaxMappingProfile : Profile
    {
        public TaxMappingProfile()
        {
            CreateMap<TaxBracket, TaxBracketViewModel>().ReverseMap();
            CreateMap<Person, PersonViewModel>().ReverseMap();
        }
    }
}