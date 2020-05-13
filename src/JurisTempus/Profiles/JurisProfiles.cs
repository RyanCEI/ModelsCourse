using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JurisTempus.Data.Entities;
using JurisTempus.ViewModels;

namespace JurisTempus.Profiles
{
  public class JurisProfiles : Profile
  {
    public JurisProfiles()
    {
      CreateMap<Client, ClientViewModel>()
        .ForMember(vm => vm.ContactName, o => o.MapFrom(s => s.Contact))
        .ForMember(m => m.Address1, o => o.MapFrom(s => s.Address.Address1))
        .ForMember(m => m.Address2, o => o.MapFrom(s => s.Address.Address2))
        .ForMember(m => m.Address3, o => o.MapFrom(s => s.Address.Address3))
        .ForMember(m => m.CityTown, o => o.MapFrom(s => s.Address.CityTown))
        .ForMember(m => m.PostalCode, o => o.MapFrom(s => s.Address.PostalCode))
        .ForMember(m => m.StateProvince, o => o.MapFrom(s => s.Address.StateProvince))
        .ForMember(m => m.Country, o => o.MapFrom(s => s.Address.Country))
        .ReverseMap();

      CreateMap<Case, CaseViewModel>()
        .ReverseMap();
    }
  }
}
