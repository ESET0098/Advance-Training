using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.Data.Entities;

namespace BookManage.cs.Data.Entities
{
    public  class SaleItems
    {
        //[Key]
        public int sale_item_id { get; set; }

        // Foreign Key to the Sale table
        public int sale_id { get; set; }

        // Foreign Key to the Book table
        public int book_id { get; set; }

        public int quantity_sold { get; set; }

        // Using decimal for monetary value
        public decimal sale_price { get; set; }

        // Navigation Properties

        //[ForeignKey("sale_id")]
        public Sales Sale { get; set; } = null!;

        //[ForeignKey("book_id")]
        public Books Book { get; set; } = null!;


    }
}
