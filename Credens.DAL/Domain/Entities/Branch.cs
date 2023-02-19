namespace Credens.DAL.Domain.Entities
{
    public class Branch
    {
        public Branch() 
        { }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public bool? IsOpen { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinal { get; set; }
    }
}
