using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CustomerApi.Data.Entities;
using CustomerApi.Data.Repository.v1;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Service.v1.Query
{
    public class GetCustomersQuery : IRequest<CustomersVm>
    {

    }

    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, CustomersVm>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Customer> _repository;

        public GetCustomersQueryHandler(IMapper mapper,IRepository<Customer> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<CustomersVm> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers =  _repository.GetAll();

            var vm = new CustomersVm
            {
                Customers = customers   
            };

            return vm;
        }
    }
}