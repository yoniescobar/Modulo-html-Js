using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class Application
    {
        public Application()
        {
            Memberships = new HashSet<Membership>();
            Roles = new HashSet<Role>();
            Users = new HashSet<User>();
        }

        [StringLength(235)]
        public string ApplicationName { get; set; } = null!;
        [Key]
        public Guid ApplicationId { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }

        [InverseProperty("Application")]
        public virtual ICollection<Membership> Memberships { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<Role> Roles { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<User> Users { get; set; }
    }
}
