
using Credens.Infrastructure.Interface;

namespace Credens.DAL.Domain.Entities
{
    public class Project : IMyEntity
    {
        public Project() { }
            public int ProjectId { get; set; }

            public int? OrderValue { get; set; }

            public int? OrderMonth { get; set; }

            public int? OrderYear { get; set; }
            public int? CustomerId { get; set; }
            public string? OrderName { get; set; }
            public int? Price { get; set; }
            public string? City { get; set; }
            public string? ResidentialComplex { get; set; }
            public string? TypeStreet { get; set; }
            public string? Street { get; set; }
            public string? BuildingNumber { get; set; }
            public string? Litera { get; set; }
            public string? BuildingPart { get; set; }
            public int? Apartment { get; set; }
            public int? Floor { get; set; }
            public int? ManagerId { get; set; }
            public int? MakerId { get; set; }
            public int? BranchId { get; set; }
    }
}
