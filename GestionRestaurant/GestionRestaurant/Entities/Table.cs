using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Table
    {
        [Key]
        public int numero_table { get; set; }
        public int nombre_places { get; set; }
      
        public virtual Affecter Affecter { get; set; }
        public virtual ICollection<Commande> Commandees { get; set; }   

    }
}
