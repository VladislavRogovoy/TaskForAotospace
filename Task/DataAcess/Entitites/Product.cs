using System.Data.Linq.Mapping;

namespace DataAcess.Entitites
{
    [Table(Name = "Products")]
    public class Product
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int StoreId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Description { get; set; }
    }
}
