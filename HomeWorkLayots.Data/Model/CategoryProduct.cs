using System.Data.Linq.Mapping;


namespace HomeWorkLayots.Data.Model
{
    [Table(Name = "CatalogGood")]
    public class CategoryProduct
    {
        [Column(Name = "GoodID")]
        public int GoodID { get; set; }
        [Column(Name = "CatalogID")]
        public int CategoryID { get; set; }
    }
}
