using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class aspnet_Path
    {
        public aspnet_Path()
        {
            aspnet_PersonalizationPerUsers = new HashSet<aspnet_PersonalizationPerUser>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid PathId { get; set; }
        [StringLength(256)]
        public string Path { get; set; } = null!;
        [StringLength(256)]
        public string LoweredPath { get; set; } = null!;

        [ForeignKey("ApplicationId")]
        [InverseProperty("aspnet_Paths")]
        public virtual aspnet_Application Application { get; set; } = null!;
        [InverseProperty("Path")]
        public virtual aspnet_PersonalizationAllUser aspnet_PersonalizationAllUser { get; set; } = null!;
        [InverseProperty("Path")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUsers { get; set; }
    }
}
