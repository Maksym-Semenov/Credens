using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Domain.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Price { get; set; }

        public string? Fio { get; set; }

        public string? Phone { get; set; }

        public string? FioDesigner { get; set; }

        public string? FioMaker { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
    }
}

