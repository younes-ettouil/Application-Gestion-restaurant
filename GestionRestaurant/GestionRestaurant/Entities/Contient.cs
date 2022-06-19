using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Contient
    {
        [Key]
        public int num_cmd { get; set; }

        public int code_plat { get; set; }
        public int quantite { get; set; }
        public virtual Commande Commande { get; set; }
        public virtual Plat Plat { get; set; }
    }
}
