using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Index("LoweredApplicationName", Name = "UQ__aspnet_A__17477DE4318583CC", IsUnique = true)]
    [Index("ApplicationName", Name = "UQ__aspnet_A__3091033175F528A6", IsUnique = true)]
    public partial class aspnet_Application
    {
        public aspnet_Application()
        {
            aspnet_Memberships = new HashSet<aspnet_Membership>();
            aspnet_Paths = new HashSet<aspnet_Path>();
            aspnet_Roles = new HashSet<aspnet_Role>();
            aspnet_Users = new HashSet<aspnet_User>();
        }

        [StringLength(256)]
        public string ApplicationName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredApplicationName { get; set; } = null!;
        [Key]
        public Guid ApplicationId { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }

        [InverseProperty("Application")]
        public virtual ICollection<aspnet_Membership> aspnet_Memberships { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<aspnet_Path> aspnet_Paths { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<aspnet_Role> aspnet_Roles { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<aspnet_User> aspnet_Users { get; set; }
    }
}
