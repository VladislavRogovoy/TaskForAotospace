using System.Data.Linq.Mapping;

namespace DataAcess.Entities
{
    [Table(Name = "Stores")]
    public class Store
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Address { get; set; }

        [Column]
        public string OperatingMode { get; set; }
    }
}
