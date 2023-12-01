using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class Course
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        // [Index("Name", IsClustered = false, IsUnique = false)]
        public string Name { get; set; }

        [Range(3, 8)]
        public int DurationInMonths { get; set; }

        [NotMapped]
        public int Fees { get; set; }
    }
}