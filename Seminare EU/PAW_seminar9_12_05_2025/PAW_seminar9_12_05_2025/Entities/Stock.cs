using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar9_12_05_2025.Entities
{
    public class Stock
    {
        // foreign key 
        public int CompanyId { get; set; }
        public DateTime Date {  get; set; }
        public decimal Open {  get; set; }
        public decimal Close {  get; set; }
        public decimal Low {  get; set; }
        public decimal High {  get; set; }
    }
}
