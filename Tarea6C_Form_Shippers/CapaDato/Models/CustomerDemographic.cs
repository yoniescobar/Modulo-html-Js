using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [StringLength(10)]
        public string CustomerTypeID { get; set; } = null!;
        [Column(TypeName = "ntext")]
        public string? CustomerDesc { get; set; }

        [ForeignKey("CustomerTypeID")]
        [InverseProperty("CustomerTypes")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
