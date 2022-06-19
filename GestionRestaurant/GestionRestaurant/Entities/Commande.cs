using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Commande
    {
        [Key]
        public int numero_cmd { get; set; }
      
        public int num_table { get; set; }
        public string date_cmd { get; set; }
        public int nombre_personnes { get; set; }
        public string heure_paiement { get; set; }
        public string mode_paiement { get; set; }
        public virtual Table Table { get; set; }
        public virtual Contient Contient { get; set; }
    }
}
