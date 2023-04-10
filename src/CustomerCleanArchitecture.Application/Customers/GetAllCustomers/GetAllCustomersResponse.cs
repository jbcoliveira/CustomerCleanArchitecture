    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCleanArchitecture.Application.Customers.GetAllCustomers
{
    public class GetAllCustomersResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
