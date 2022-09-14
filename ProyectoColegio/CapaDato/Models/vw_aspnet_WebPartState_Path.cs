using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Keyless]
    public partial class vw_aspnet_WebPartState_Path
    {
        public Guid ApplicationId { get; set; }
        public Guid PathId { get; set; }
        [StringLength(256)]
        public string Path { get; set; } = null!;
        [StringLength(256)]
        public string LoweredPath { get; set; } = null!;
    }
}
