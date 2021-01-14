using System.Data.Linq.Mapping;

namespace HomeWorkLayots.Data.Model
{
    [Table(Name = "Good")]
    public class Product
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "Company")]
        public string Company { get; set; }
        [Column(Name = "Price")]
        public decimal Price { get; set; }
    }
}
