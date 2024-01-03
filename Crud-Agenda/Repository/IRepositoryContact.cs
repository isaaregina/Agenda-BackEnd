using Crud_Agenda.Model;

namespace Crud_Agenda.Repository
{
    public interface IRepositoryContact
    {
        void GetAllContact();
        void GetByEmail(string email);
        void CreateContact(ContactModel contact);
        void UpdateContact(ContactModel contact);
        void DeleteContact(ContactModel contact);



    }
}
