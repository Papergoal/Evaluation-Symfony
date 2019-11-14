using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSymfony.ORM
{
    class ContexteBDD : DbContext
    {

        public ContexteBDD()
            : base("ChaineDeConnexion")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Jeu> Jeux { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
