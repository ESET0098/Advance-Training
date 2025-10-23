using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BookManage.cs.Data.Entities;

namespace BookManage.Data.Entities
{
    public class Books
    {
        //[Key]
        public int book_id { get; set; }

        //[Required, MaxLength(50)]
        public string title { get; set; } = string.Empty;

        //[Required, MaxLength(50)]
        public string author { get; set; } = string.Empty;

        //[Required]
        //[Column(TypeName = "decimal(18, 2)")] 
        public decimal current_price { get; set; }

        public int? stock_quantity { get; set; }

        public ICollection<SaleItems> SaleItems { get; set; } = new List<SaleItems>();
    }
}
