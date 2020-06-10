using System.Collections.Generic;
using CustomerApi.Data.Entities;

namespace  CustomerApi.Service.v1.Query
{
    public class CustomersVm
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}