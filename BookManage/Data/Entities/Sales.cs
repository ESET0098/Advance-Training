using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManage.cs.Data.Entities
{
   public  class Sales
    {
        //[Key]
        public int sale_id { get; set; }

        public int customer_id { get; set; }

        //[Required]
       
        public DateTime sale_date { get; set; }

       
        //[ForeignKey("customer_id")] 
        public Customers Customer { get; set; } = null!;


        public ICollection<SaleItems> SaleItems { get; set; } = new List<SaleItems>();



    }
}
