using Crud_Agenda.Data;
using Crud_Agenda.Model;
using Microsoft.EntityFrameworkCore;

namespace Crud_Agenda.Repository
{
    public class RepositoryContact : IRepositoryContact
    {
        public readonly ContactContext _context;

        public void CreateContact(ContactModel Contact)
        {
            this._context.Contacts.Add(Contact);
            this._context.SaveChanges();
        }

        public void DeleteContact(ContactModel Contact)
        {
            this._context.Contacts.Remove(Contact);
        }

        public List<ContactModel> GetAllContact()
        {
            return this._context.Contacts.ToList();
        }

        public async Task<ContactModel> GetByEmail(string Email)
        {
            return await this._context.Contacts.Where(x => x.email == Email).FirstOrDefaultAsync();
        }

        public void UpdateContact(ContactModel Contact)
        {
            this._context.Contacts.Update(Contact);
        }
    }
}
