using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models.Contracts
{
    public interface IDeletable
    {
        [NotMapped]
        bool IsDeleted { get; set; }

        [NotMapped]
        DateTime? DeletedOn { get; set; }
    }
}
