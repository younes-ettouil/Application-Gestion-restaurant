using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Entities
{
    internal class Plat
    {
        [Key]
        public int code_plat { get; set; }
        public string libelle { get; set; }
        public string type_plat { get; set; }
        public double prix { get; set; }
        public virtual ICollection<Contient> Contients { get; set; }
    }
}
