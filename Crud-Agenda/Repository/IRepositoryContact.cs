using Crud_Agenda.Model;

namespace Crud_Agenda.Repository
{
    public interface IRepositoryContact
    {
        List<ContactModel> GetAllContact();
        Task<ContactModel> GetByEmail(string Email);
        void CreateContact(ContactModel Contact);
        void UpdateContact(ContactModel Contact);
        void DeleteContact(ContactModel Contact);



    }
}
