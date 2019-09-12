using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class Tkan
    {
        [Key]
        public int Articul { get; set; }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Uzor { get; set; }
       
       // public byte?[] Picture { get; set; }
        public string Picture { get; set; }

        public string Sostav { get; set; }
        public decimal Shirina { get; set; }
        public decimal Dlina { get; set; }
        public decimal Cena{ get; set; }

        public List<ScladTkan> ScladTkans { get; set; }
        public List<TkanIzd> TkanIzds { get; set; }

    }

}
