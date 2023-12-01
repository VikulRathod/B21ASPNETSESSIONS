using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        public int RollNumber { get; set; }

        [Column("StudentName", TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Column("Gender", TypeName = "varchar")]
        [MaxLength(20)]
        public string Gender { get; set; }

        [ForeignKey("Trainer")]
        public Nullable<int> TrainerId { get; set; }

        public Trainer Trainer { get; set; } // navigation property
    }
}