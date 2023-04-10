using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCleanArchitecture.Application.Customers.GetAllCustomers
{
    public class GetAllCustomersRequest : IRequest<List<GetAllCustomersResponse>>
    {
    }
}
