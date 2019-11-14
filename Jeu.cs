using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSymfony.ORM
{
    public class Jeu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NomJeu { get; set; }

        [Required]
        [StringLength(50)]
        public string PlateformeJeu { get; set; }

        public bool StatutStock { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public Jeu()
        {
            Clients = new List<Client>();
        }
    }
}
