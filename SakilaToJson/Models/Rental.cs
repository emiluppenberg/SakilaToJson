using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson.Models
{
    [PrimaryKey("rental_id")]
    internal class Rental
    {
        public int rental_id { get; set; }
        public DateTime rental_date { get; set; }
        public int inventory_id { get; set; }
        public int customer_id { get; set; }
        public DateTime? return_date { get; set; }
        public byte staff_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
