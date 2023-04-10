using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCleanArchitecture.Domain.Entities
{
    public class Customer
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
