using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Keyless]
    public partial class vw_aspnet_Role
    {
        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        [StringLength(256)]
        public string RoleName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredRoleName { get; set; } = null!;
        [StringLength(256)]
        public string? Description { get; set; }
    }
}
