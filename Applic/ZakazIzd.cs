using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class ZakazIzd
    {
        [Key]
        [Column(Order = 1)]
        public int NomerZakaz { get; set; }
        public Zakaz Zakaz { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ArtculZakaz { get; set; }
        public Izdelie Izdelie { get; set; }

        public int Kolichestvo { get; set; }

    }
}
