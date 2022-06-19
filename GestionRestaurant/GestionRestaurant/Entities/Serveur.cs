using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Serveur
    {
        [Key]
        public int numero_serveur { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public virtual ICollection<Affecter> Affecters { get; set; }
    }
}
