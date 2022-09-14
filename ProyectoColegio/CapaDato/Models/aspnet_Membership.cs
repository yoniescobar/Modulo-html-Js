﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    [Table("aspnet_Membership")]
    public partial class aspnet_Membership
    {
        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        [StringLength(128)]
        public string Password { get; set; } = null!;
        public int PasswordFormat { get; set; }
        [StringLength(128)]
        public string PasswordSalt { get; set; } = null!;
        [StringLength(16)]
        public string? MobilePIN { get; set; }
        [StringLength(256)]
        public string? Email { get; set; }
        [StringLength(256)]
        public string? LoweredEmail { get; set; }
        [StringLength(256)]
        public string? PasswordQuestion { get; set; }
        [StringLength(128)]
        public string? PasswordAnswer { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastLoginDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastPasswordChangedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FailedPasswordAttemptWindowStart { get; set; }
        public int FailedPasswordAnswerAttemptCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
        [Column(TypeName = "ntext")]
        public string? Comment { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("aspnet_Memberships")]
        public virtual aspnet_Application Application { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("aspnet_Membership")]
        public virtual aspnet_User User { get; set; } = null!;
    }
}
