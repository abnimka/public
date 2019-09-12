using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class FurnituraIzd
    {
        [Key]
        [Column(Order = 1)]
        public int ArticulFur { get; set; }
        public Furnitura Furnitura { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ArticulIzd { get; set; }
        public Izdelie Izdelie { get; set; }


        public string Razmeschenie { get; set; }
        public float? Shirina { get; set; }
        public float? Dlina { get; set; }
        public float? Ugol { get; set; }
        public int Kolichestvo { get; set; }
    }
}
