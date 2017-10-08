using Ivysoft.OnlineSystem.Data.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models
{
    [Table("Order Details")]
    public partial class OrderDetail/* : DataModel*/
    {
        [Key]
        [Column("OrderID", Order = 1)]
        public int OrderId { get; set; }

        [Key]
        [Column("ProductID", Order = 2)]
        public int ProductId { get; set; }

        public float Discount { get; set; }

        public short Quantity { get; set; }
        
        public decimal UnitPrice { get; set; }

        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }

        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; }
    }
}
