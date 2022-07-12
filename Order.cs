using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("orders")]

internal class Order
{
    [Key]
    public int OrderId { get; set; }
    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Amount { get; set; }

    public string Status { get; set; }
 
    
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<Product> ProductCart { get; set; } 
}

