using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
