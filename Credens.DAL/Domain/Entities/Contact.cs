using Credens.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Domain.Entities
{
    public class Contact 
    {
        public Contact(){}
        public int ContactId { get; set; }
        public string? City { get; set; }
        public string? ResidentialComplex { get; set; }
        public string? TypeStreet { get; set; }
        public string? Street { get; set; }
        public string? BuildingNumber { get; set; }
        public string? Litera { get; set; }
        public string? BuildingPart { get; set; }
        public int? Apartment { get; set; }
        public int? Floor { get; set; }
    }
}
