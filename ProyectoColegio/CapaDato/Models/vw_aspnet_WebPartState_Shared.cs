using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Keyless]
    public partial class vw_aspnet_WebPartState_Shared
    {
        public Guid PathId { get; set; }
        public int? DataSize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }
    }
}
