using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTUAN3.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string Origin { get; set; }
        public DateTime Expired { get; set; }
    }
}
