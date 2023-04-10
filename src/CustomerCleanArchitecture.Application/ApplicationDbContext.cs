using CustomerCleanArchitecture.Application.Context;
using CustomerCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerCleanArchitecture.Application
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        public async Task<int> SaveToDbAsync()
        {
            return await SaveChangesAsync();
        }
    }
}