using System.Data.Linq.Mapping;

namespace HomeWorkLayots.Data.Model
{
    [Table(Name = "Catalog")]
    public class Category
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
    }
}
