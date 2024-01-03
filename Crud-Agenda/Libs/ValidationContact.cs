using Crud_Agenda.Model;

namespace Crud_Agenda.Validation
{
    public class ValidationContact
    {
        public static void Validation(ContactModel contact)
        {
            if (contact == null) throw new ArgumentException("Preencha todos os campos");
            if (string.IsNullOrWhiteSpace(contact.name)) throw new ArgumentException("Preencha o campo nome");
            if (string.IsNullOrWhiteSpace(contact.email)) throw new ArgumentException("Preencha o campo email");
            if (string.IsNullOrWhiteSpace(contact.phone)) throw new ArgumentException("Preencha o campo email");

        }
    }
}
