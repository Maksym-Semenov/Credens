using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.DTO
{
    internal class ProjectDto
    {
        public int Id { get; set; }

        public string OrderNum { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string? Price { get; set; }

        public string? Descr { get; set; }

        public string? Address { get; set; }

        public string? Fio { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? FioDesigner { get; set; }

        public string? FioMaker { get; set; }

        public int? IsCompleted { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
        public string Description { get; set; }

    }
}
