using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class TkanIzd
    {
        [Key]
        [Column(Order = 1)]
        public int ArticulTkan { get; set; }
        public Tkan Tkan { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ArticulIzd { get; set; }
        public Izdelie Izdelie { get; set; }

    }
}
