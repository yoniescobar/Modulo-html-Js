using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class aspnet_PersonalizationAllUser
    {
        [Key]
        public Guid PathId { get; set; }
        [Column(TypeName = "image")]
        public byte[] PageSettings { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("PathId")]
        [InverseProperty("aspnet_PersonalizationAllUser")]
        public virtual aspnet_Path Path { get; set; } = null!;
    }
}
