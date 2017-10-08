using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models.Contracts
{
    public interface IAuditable
    {
        [NotMapped]
        DateTime? CreatedOn { get; set; }

        [NotMapped]
        DateTime? ModifiedOn { get; set; }
    }
}
