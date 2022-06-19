using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Affecter
    {
        [Key]
        public int numero_table { get; set; }
        public int numero_serveur { get; set; }
        public string date_affectation { get; set; }
        public virtual Table Table { get; set; }
        public virtual Serveur Serveur { get; set; }
    }
}
