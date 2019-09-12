using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic
{
    public class Zakaz
    {
        [Key]
        [Column(Order = 1)]
        public int Nomer { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime DateZ { get; set; }

        //[Required]
        //[Check("Новый", "Ожидает","Обработка","Отклонен","К оплате","Оплачен","Раскрой", "Производство","Готов")]
        public string Stage { get; set; }
        // Ссылка на заказчика
        public User Zakazchik { get; set; }
        //  Ссылка на продавца
        public User Manager { get; set; }
        public float? Stoimost { get; set; }

        // Ссылка на заказы
        public List<ZakazIzd> ZakazIzds { get; set; }

    }
}
