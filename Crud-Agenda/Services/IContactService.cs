using Crud_Agenda.Model;

namespace Crud_Agenda.Services
{
    public interface IContactService
    {
        List<ContactModel> GetAllContact();
        Task<ContactModel> GetByEmail(string Email);
        void CreateContact(ContactModel Contact);
        void UpdateContact(int id, ContactModel Contact);
        void DeleteContact(int id, ContactModel Contact);
    }
}
