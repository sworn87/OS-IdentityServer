using System.Linq;
using Ivysoft.OnlineSystem.Data.Models;
using Ivysoft.OnlineSystem.Data.Repositories;
using Ivysoft.OnlineSystem.Data.SaveContext;

namespace Ivysoft.OnlineSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IEfRepository<Customer> customersRepo;
        private readonly ISaveContext context;

        public CustomerService(IEfRepository<Customer> customersRepo, ISaveContext context)
        {
            this.customersRepo = customersRepo;
            this.context = context;
        }

        public IQueryable<Customer> GetAll()
        {
            return this.customersRepo.All;
        }

        public void Update(Customer customer)
        {
            this.customersRepo.Update(customer);
            this.context.Commit();
        }
    }
}
