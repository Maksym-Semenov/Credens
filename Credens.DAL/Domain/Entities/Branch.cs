using Credens.Infrastructure.Interface;

namespace Credens.DAL.Domain.Entities
{
    public class Branch 
    {
        public Branch() { }
        public int BranchId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? IsOpen { get; set; }
    }
}
