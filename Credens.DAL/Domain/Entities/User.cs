using Credens.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Domain.Entities
{
    public class User :IMyEntity
    {
        public User(){}
        public int UserId { get; set; }  
        
        public string? FirstName { get; set; }  
        
        public string? MiddleName { get; set; }   
        
        public string? LastName { get; set; }   
        
        public int? UserRole { get; set; }
    }
}
