using Ivysoft.OnlineSystem.Data.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models
{
    public partial class EmployeeTerritory/* : DataModel*/
    {
        [Key]
        [Column("EmployeeID", Order = 1)]
        public int EmployeeId { get; set; }

        [Key]
        [Column("TerritoryID", Order = 2)]
        [MaxLength(20)]
        public string TerritoryId { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("EmployeeTerritories")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("TerritoryId")]
        [InverseProperty("EmployeeTerritories")]
        public virtual Territory Territory { get; set; }
    }
}
