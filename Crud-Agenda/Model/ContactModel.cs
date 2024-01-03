using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Agenda.Model
{
    [Table("contacts")]
    public class ContactModel
    {
        [Key]

        public int id { get; set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }

        public ContactModel()
        {
        }

        public ContactModel(string name, string email, string phone)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.phone = phone ?? throw new ArgumentNullException(nameof(phone));
        }

        
    }
}
