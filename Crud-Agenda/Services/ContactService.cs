using Crud_Agenda.Data;
using Crud_Agenda.Libs;
using Crud_Agenda.Model;
using Crud_Agenda.Repository;

namespace Crud_Agenda.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepositoryContact repository;

        private readonly ContactContext context;

        public ContactService(IRepositoryContact repository, ContactContext context)
        {
            this.repository = repository;
            this.context = context;
        }

        public void CreateContact(ContactModel Contact)
        {
            ValidationContact.Validation(Contact);

            this.repository.CreateContact(Contact);

        }

        public void DeleteContact(int id, ContactModel Contact)
        {
            var contact = this.repository.GetById(id);

            if (contact == null) throw new ArgumentException("Usuário não encontrado");

            this.repository.DeleteContact(Contact);
        }

        public List<ContactModel> GetAllContact()
        {
            return this.repository.GetAllContact();      
        }

        public async Task<ContactModel> GetByEmail(string Email)
        {
            var contact = await this.repository.GetByEmail(Email);

            if (contact == null) throw new ArgumentException("Usuário não encontrado");

            return await this.repository.GetByEmail(Email);
        }
        public async void UpdateContact(int id, ContactModel Contact)
        {
            ValidationContact.Validation(Contact);

            var contact = await this.repository.GetById(id);

            contact.name = Contact.name;
            contact.email = Contact.email;
            contact.phone = Contact.phone;
           
            this.repository.UpdateContact(contact);
        }
    }
}
