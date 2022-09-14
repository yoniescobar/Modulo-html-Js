using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Index("ApplicationId", "LastActivityDate", Name = "aspnet_Users_Index2")]
    public partial class aspnet_User
    {
        public aspnet_User()
        {
            aspnet_PersonalizationPerUsers = new HashSet<aspnet_PersonalizationPerUser>();
            Roles = new HashSet<aspnet_Role>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        [StringLength(256)]
        public string UserName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredUserName { get; set; } = null!;
        [StringLength(16)]
        public string? MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastActivityDate { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("aspnet_Users")]
        public virtual aspnet_Application Application { get; set; } = null!;
        [InverseProperty("User")]
        public virtual aspnet_Membership aspnet_Membership { get; set; } = null!;
        [InverseProperty("User")]
        public virtual aspnet_Profile aspnet_Profile { get; set; } = null!;
        [InverseProperty("User")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUsers { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Users")]
        public virtual ICollection<aspnet_Role> Roles { get; set; }
    }
}
