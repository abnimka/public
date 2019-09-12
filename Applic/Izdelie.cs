using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class Izdelie
    {
        [Key]
        public int Articul { get; set; }

        public string Name { get; set; }
        public float Shirina { get; set; }
        public float Dlina { get; set; }
        public byte?[] Picture { get; set; }
        public string Komment { get; set; }

        // Ссылка на заказы
        public List<ZakazIzd> ZakazIzds { get; set; }
        public List<FurnituraIzd> FurnituraIzds { get; set; }
        public List<TkanIzd> TkanIzds { get; set; }
    }


}
