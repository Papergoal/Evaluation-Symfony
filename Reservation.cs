using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSymfony.ORM
{
    class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Client { get; set; }

        [Required]
        [StringLength(50)]

        public string Jeu { get; set; }

        public DateTime DateReservation { get; set; }
    }
}