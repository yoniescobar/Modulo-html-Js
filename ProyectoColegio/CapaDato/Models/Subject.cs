using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CapaDato.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Grades = new HashSet<Grade>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [InverseProperty("Subject")]
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
