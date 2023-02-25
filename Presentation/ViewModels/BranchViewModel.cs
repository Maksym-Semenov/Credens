using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Domain.ViewModels
{
    public class BranchViewModel
    {
        public int Id { get; set; }

        public string Location { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

    }
}
