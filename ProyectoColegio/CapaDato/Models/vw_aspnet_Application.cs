using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Keyless]
    public partial class vw_aspnet_Application
    {
        [StringLength(256)]
        public string ApplicationName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredApplicationName { get; set; } = null!;
        public Guid ApplicationId { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }
    }
}
