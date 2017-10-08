using Ivysoft.OnlineSystem.Data.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models
{
    public partial class CustomerDemographics/* : DataModel*/
    {
        public CustomerDemographics()
        {
            CustomerCustomerDemo = new HashSet<CustomerCustomerDemo>();
        }

        [Key]
        [Column("CustomerTypeID"), MaxLength(10)]
        public string CustomerTypeId { get; set; }

        public string CustomerDesc { get; set; }

        [InverseProperty("CustomerType")]
        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
