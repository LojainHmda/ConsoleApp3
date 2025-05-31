using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApp3.Models
{
    public class Blog

    {
        public int Id {get;set ;}
        public string Title { get; set; }
        public string Description { get; set; }

        public User User { get; set; }  
        public int UserId { get; set; }
    }
}
