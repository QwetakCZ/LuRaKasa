using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskopLuRaKasa.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }

        [ForeignKey("IdCategory")]
        public Category Category { get; set; }

        public decimal? Price { get; set; }

        public decimal? DPH { get; set; }

        public decimal? PricePrice { get; set; }

    }
}
