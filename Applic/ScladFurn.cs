using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class ScladFurn
    {
        [Key]
        [Column(Order = 1)]
        public int Partiya { get; set; }
        [Key]
        [Column(Order = 2)]
        public Furnitura ArticulFurn { get; set; }
        public float Kolichestvo { get; set; }//количество единиц в партии
        
    }
}
