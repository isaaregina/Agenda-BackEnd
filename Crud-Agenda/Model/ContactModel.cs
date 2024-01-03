using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Agenda.Model
{
    [Table("contacts")]
    public class ContactModel
    {
        [Key]

        public string name { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }

    }
}
