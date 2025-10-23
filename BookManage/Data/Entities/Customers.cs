using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManage.cs.Data.Entities
{
    public class Customers
    {
        //[Key]
        public int customer_id { get; set; }

        //[Required, MaxLength(100)]
        public required string customer_name { get; set; }
        

        public ICollection<Sales> Sales { get; set; } = new List<Sales>();  

    }
}
