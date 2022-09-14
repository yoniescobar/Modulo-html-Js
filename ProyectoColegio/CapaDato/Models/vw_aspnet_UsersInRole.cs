using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Keyless]
    public partial class vw_aspnet_UsersInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
