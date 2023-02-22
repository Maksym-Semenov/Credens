using Credens.DAL.Domain.Enums;

namespace Credens.DAL.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string? OrderNum { get; set; } 
       
       // public bool IsOrder { get; set; }

        public string Name { get; set; }

        public string? Price { get; set; }

        public string? Descr { get; set; }

        public string? Address { get; set; }

        public string? Fio { get; set; }

        public string? Phone { get; set; }

        public string? Phone2 { get; set; } 

        public string? Email { get; set; }

        public string? FioDesigner { get; set; }

        public string? FioMaker { get; set; }

        public int? IsCompleted { get; set; }

       // public OrderStatus OrderStatus { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
    }
}
