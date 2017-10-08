using Ivysoft.OnlineSystem.Data.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models
{
    public partial class Region/* : DataModel*/
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        [Column("RegionID")]
        public int RegionId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RegionDescription { get; set; }

        [InverseProperty("Region")]
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
