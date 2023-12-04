using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCompanyCodeFirst.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set;}
        public string PhoneName { get; set;}
        public string Adress { get; set;}
        //bir müşterinin birden çok siparişi olabilir.
        public List<Order> Orders { get;}
    }
}
