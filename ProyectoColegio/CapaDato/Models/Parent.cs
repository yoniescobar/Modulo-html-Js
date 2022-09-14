using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Students_Users = new HashSet<Student>();
        }

        [Key]
        public Guid UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("Parent")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("Parents_UserId")]
        [InverseProperty("Parents_Users")]
        public virtual ICollection<Student> Students_Users { get; set; }
    }
}
