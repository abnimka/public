using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class Furnitura
    {
        [Key]
        public int Articul { get; set; }

        public string Name { get; set; }
        public string Tip { get; set; }
        public float Shirina { get; set; }
        public float? Dlina { get; set; }
        public float? Ves { get; set; }
        public byte?[] Picture { get; set; }
        public float Cena { get; set; }

        public List<FurnituraIzd> FurnituraIzds { get; set; }
        public List<ScladFurn> ScladFurns { get; set; }
    }
}
