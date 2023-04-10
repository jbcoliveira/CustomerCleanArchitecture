using CustomerCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerCleanArchitecture.Application.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customer { get; }

        Task<int> SaveToDbAsync();
    }
}