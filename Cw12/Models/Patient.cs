using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cw12.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        public int IdPatient { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
