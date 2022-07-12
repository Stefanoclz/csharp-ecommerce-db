// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World");

using(EcommerceContext db = new EcommerceContext())
{
    //***** CREAZIONE E AGGIUNTA PRODOTTI******
    
    Product first = new Product { Name = "Ibanez", Description = "Chitarra elettrica fascia medio-alta, il caratteristico suono secco è oramai un marchio in tutto il mondo, rapendo il cuore di grandi chitareisati cone Steve Vai, Joe Satriani e Paol Gilbert", Price = 550 };
    Product second = new Product { Name = "Squier", Description = "Fascia bassa ma grande casa madre, questa chitarra è tra le più vendute in assoluto per chi vuole iniziare ma allo stesso tempo fidarsi della qualità seppur a basso costo in questo caso della Fender", Price = 150 };
    Product third = new Product { Name = "MXR Distortion 3", Description = "Ami il metal e l'hard rock? Bene, questo pedale è esattamente quello che cerchi, aggressivo ma corposo può aiutare qualsiasi riff a diventare epico!", Price = 95 };
    Product fourth = new Product { Name = "Ernie ball 09", Description = "Corde in lega di metallo perfette per un suono morbido", Price = 18 };
    Product fifth = new Product { Name = "Picks Pack", Description = "Kit di 50 plettri per non rimanere mai senza, perchè si sà, hanno vita loro e scompaiono misteriosamente", Price = 10 };
    /*
    db.Add(first);
    db.Add(second);
    db.Add(third);
    db.Add(fourth);
    db.Add(fifth);
    db.SaveChanges();

    Console.WriteLine("Recupero lista di Studenti");
    List<Product> products = db.Products.OrderBy(products => products.Name).ToList<Product>();
    */

    //***** CREAZIONE E AGGIUNTA UTENTI******
    /*
    Customer cust1 = new Customer { Name = "Ugo", Surname = "Fantozzi", Email = "fantocci@email.it" };
    Customer cust2 = new Customer { Name = "Keanu", Surname = "Reeves", Email = "keanrev@email.it" };
    Customer cust3 = new Customer { Name = "Jhonny", Surname = "Silòverhand", Email = "samuraihand@email.it" };
    db.Add(cust1);
    db.Add(cust2);
    db.Add(cust3);
    db.SaveChanges();
    */

    //***** CREAZIONE E AGGIUNTA ORDINI******

    Order ord1 = new Order { Date = DateTime.Parse("20/06/2022"), Status = "Spedito", CustomerId = 2, Amount = 0};
    ord1.AddProducts(first);
    ord1.AddProducts(third);
    ord1.Amount = ord1.GetAmount();

    Order ord2 = new Order { Date = DateTime.Parse("15/02/2022"), Status = "Consegnato", CustomerId = 1, Amount = 0 };
    ord2.AddProducts(fourth);
    ord2.Amount = ord2.GetAmount();

    Order ord3 = new Order { Date = DateTime.Parse("10/07/2022"), Status = "Pagamento in verifica", CustomerId = 3, Amount = 0 };
    ord3.AddProducts(second);
    ord3.Amount = ord3.GetAmount();

    Order ord4 = new Order { Date = DateTime.Parse("12/12/2021"), Status = "Consegnato", CustomerId = 1, Amount = 0 };
    ord4.AddProducts(third);
    ord4.AddProducts(first);
    ord4.Amount = ord4.GetAmount();

    Order ord5 = new Order { Date = DateTime.Parse("11/07/2022"), Status = "In preparazione", CustomerId = 2, Amount = 0 };
    ord5.AddProducts(fourth);
    ord5.AddProducts(fifth);
    ord5.Amount = ord5.GetAmount();

    db.Add(ord1);
    db.Add(ord2);
    db.Add(ord3);
    db.Add(ord4);
    db.Add(ord5);
    db.SaveChanges();



}