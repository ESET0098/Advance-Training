using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManage.cs.Data.Entities
{
   public  class User
    {
        //[Key]
        public int user_id { get; set; }

        //[Required,MaxLength(100)]
        public string username { get; set; }

        //[Required, MaxLength(101)]
        public string password { get; set; }

        
       


       
    }
}
