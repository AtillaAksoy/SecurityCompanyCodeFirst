using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCompanyCodeFirst.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDetail { get; set; }

        //mapping
        public int EmployeId { get; set; }
        public int CustomerId { get; set; }
        public List<Employe> Employes{ get; set;}

    }
}
