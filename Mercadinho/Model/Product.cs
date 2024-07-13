using System.ComponentModel.DataAnnotations;

namespace Mercadinho.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price  { get; set; }
        public int Amount { get; set; }
    }
}
