using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public string Log { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Passw { get; set; }

        public string Role { get; set; }
        public string Naimen { get; set; }//необязательное

        // Ссылка на заказы
        public List<Zakaz> Zakazs { get; set; }

    }

}
