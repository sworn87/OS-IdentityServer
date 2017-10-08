using Ivysoft.OnlineSystem.Data.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivysoft.OnlineSystem.Data.Models.Abstracts
{
    public abstract class DataModel : IAuditable, IDeletable
    {
        //public DataModel()
        //{
        //    this.Id = Guid.NewGuid();
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //[Index]

        [NotMapped]
        public bool IsDeleted { get; set; }


        [NotMapped]
        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }


        [NotMapped]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }


        [NotMapped]
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}
