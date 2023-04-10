using AutoMapper;
using AutoMapper.QueryableExtensions;
using CustomerCleanArchitecture.Application.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCleanArchitecture.Application.Customers.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersRequest, List<GetAllCustomersResponse>>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public GetAllCustomersQueryHandler(IApplicationDbContext myWorldDbContext,
        IMapper mapper)
        {
            _applicationDbContext = myWorldDbContext;
            _mapper = mapper;
        }
        public Task<List<GetAllCustomersResponse>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
        {
            return _applicationDbContext.Customer.ProjectTo<GetAllCustomersResponse>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }
    }
}
