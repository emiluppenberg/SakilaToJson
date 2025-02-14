using SakilaToJson;

var context = new SakilaDbContext();
var jsonizer = new Jsonizer();

var customers = context.customer.ToList();
var films = context.film.ToList();
var inventorys = context.inventory.ToList();
var payments = context.payment.ToList();
var rentals = context.rental.ToList();

jsonizer.CustomerToJson(customers);
jsonizer.FilmToJson(films);
jsonizer.InventoryToJson(inventorys);
jsonizer.PaymentToJson(payments);
jsonizer.RentalToJson(rentals);

Console.ReadKey();