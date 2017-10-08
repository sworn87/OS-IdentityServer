using Ivysoft.OnlineSystem.Data.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models
{
    public partial class CustomerCustomerDemo/* : DataModel*/
    {
        [Key]
        [Column("CustomerID", Order = 1)]
        [MaxLength(5)]
        public string CustomerId { get; set; }

        [Key]
        [Column("CustomerTypeID", Order = 2)]
        [MaxLength(10)]
        public string CustomerTypeId { get; set; }

        [InverseProperty("CustomerCustomerDemo")]
        public virtual Customer Customer { get; set; }

        [InverseProperty("CustomerCustomerDemo")]
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
