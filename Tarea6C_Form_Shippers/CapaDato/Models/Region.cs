using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Table("Region")]
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        [Key]
        public int RegionID { get; set; }
        [StringLength(50)]
        public string RegionDescription { get; set; } = null!;

        [InverseProperty("Region")]
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
