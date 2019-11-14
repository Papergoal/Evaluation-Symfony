using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSymfony.ORM
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string NomClient { get; set; }

        [Required]
        [StringLength(50)]
        public string IdClient { get; set; }

        [Required]
        [StringLength(50)]
        public string MotDePasseClient { get; set; }

        [EmailAddress]
        public string EmailClient { get; set; }

        public virtual ICollection<Jeu> Jeux { get; set; }

        public Client()
        {
            Jeux = new List<Jeu>();
        }
    }
}
