using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCompanyCodeFirst.Entities
{
    public class Employe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
        //bir çalışanın bir siparişi olur bir siparişte birden fazla çalışan olabilir (çoka çok olunca ek tablo ve context te ilişkilendirme.)
        public Order order { get; set; }

    }
}
