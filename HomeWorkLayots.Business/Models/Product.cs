using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeWorkLayots.Business.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Product()
        {
            Categories = new List<Category>();
        }
    }
}
