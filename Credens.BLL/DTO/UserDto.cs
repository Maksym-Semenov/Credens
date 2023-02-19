using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.DTO
{
    internal class UserDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }

        public DateTime? Birthday { get; set; }
    }
}
