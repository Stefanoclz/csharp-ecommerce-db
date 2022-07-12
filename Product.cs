using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("products")]
internal class Product
{
    [Key]
    public int ProductId { get; set; }
    public string Name { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Price { get; set; }
    public List<Order> Ordered { get; set; }
}
