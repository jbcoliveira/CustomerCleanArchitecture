using AutoMapper;
using CustomerCleanArchitecture.Application.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCleanArchitecture.Application.Customers.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerRequest, int>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public CreateCustomerCommandHandler(IApplicationDbContext myWorldDbContext,
        IMapper mapper)
        {
            _applicationDbContext = myWorldDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var newCustomer = _mapper.Map<Domain.Entities.Customer>(request);
            _applicationDbContext.Customer.Add(newCustomer);
            await _applicationDbContext.SaveToDbAsync();
            return newCustomer.Id;
        }
    }
}
