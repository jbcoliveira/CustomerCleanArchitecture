using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerCleanArchitecture.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}