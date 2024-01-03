using AutoMapper;
using Crud_Agenda.DTO;
using Crud_Agenda.Model;

namespace Crud_Agenda.Mappers
{
    public class ContactMappers : Profile
    {
        public ContactMappers() 
        {
            CreateMap<ContactModel, ContactDTO>();
        }
    }
}
