using SakilaToJson.Models;
using SakilaToJson.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace SakilaToJson
{
    internal class Jsonizer
    {
        private string path = "C:\\Users\\ÄGARE\\Desktop\\";

        public void CustomerToJson(List<Customer> customers)
        {
            var lines = new List<string>();

            foreach (var c in customers)
            {
                var cj = new CustomerJson() { customer_id = c.customer_id };
                var json = JsonSerializer.Serialize(cj);
                lines.Add(json);
            }

            File.AppendAllLines(path + "customers.json", lines);
        }

        public void FilmToJson(List<Film> films)
        {
            var lines = new List<string>();

            foreach (var f in films)
            {
                var fj = new FilmJson() { film_id = f.film_id, rating = f.rating };
                var json = JsonSerializer.Serialize(fj);
                lines.Add(json);
            }

            File.AppendAllLines(path + "films.json", lines);
        }

        public void InventoryToJson(List<Inventory> inventorys)
        {
            var lines = new List<string>();

            foreach (var i in inventorys)
            {
                var ij = new InventoryJson() { inventory_id = i.inventory_id, film_id = i.film_id };
                var json = JsonSerializer.Serialize(ij);
                lines.Add(json);
            }

            File.AppendAllLines(path + "inventorys.json", lines);
        }

        public void PaymentToJson(List<Payment> payments)
        {
            var lines = new List<string>();

            foreach (var p in payments)
            {
                var pj = new PaymentJson() { payment_id = p.payment_id, amount = p.amount, customer_id = p.customer_id };
                var json = JsonSerializer.Serialize(pj);
                lines.Add(json);
            }

            File.AppendAllLines(path + "payments.json", lines);
        }

        public void RentalToJson(List<Rental> rentals)
        {
            var lines = new List<string>();

            foreach (var r in rentals)
            {
                var rj = new RentalJson() { rental_id = r.rental_id, inventory_id = r.inventory_id, customer_id = r.customer_id };
                var json = JsonSerializer.Serialize(rj);
                lines.Add(json);
            }

            File.AppendAllLines(path + "rentals.json", lines);
        }
    }
}
