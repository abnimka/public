using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class ScladTkan
    {
        [Key]
        [Column(Order = 1)]
        public int Rulon { get; set; }
        [Key]
        [Column(Order = 2)]
        public Tkan ArticulTkan { get; set; }


        public float Shirina { get; set; }//ширина ткани в рулоне
        public float Dlina { get; set; }//длина ткани в рулоне

    }
}
