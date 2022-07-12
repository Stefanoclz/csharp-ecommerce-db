using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("customers")]
internal class Customer
{
    [Key]
    public int CustomerId { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    List<Order> Orders { get; set; }
}

