using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.DTO
{
    internal class BranchDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Location { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int? IsOpen { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
    }
}
