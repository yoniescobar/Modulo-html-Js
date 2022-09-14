using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class aspnet_Role
    {
        public aspnet_Role()
        {
            Users = new HashSet<aspnet_User>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid RoleId { get; set; }
        [StringLength(256)]
        public string RoleName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredRoleName { get; set; } = null!;
        [StringLength(256)]
        public string? Description { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("aspnet_Roles")]
        public virtual aspnet_Application Application { get; set; } = null!;

        [ForeignKey("RoleId")]
        [InverseProperty("Roles")]
        public virtual ICollection<aspnet_User> Users { get; set; }
    }
}
