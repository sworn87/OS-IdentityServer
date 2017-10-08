using Ivysoft.OnlineSystem.Data.Models;
using System.Linq;

namespace Ivysoft.OnlineSystem.Services
{
    public interface ICustomerService
    {
        IQueryable<Customer> GetAll();

        void Update(Customer customer);
    }
}
