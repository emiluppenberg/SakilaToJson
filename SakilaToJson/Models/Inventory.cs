using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson.Models
{
    [PrimaryKey("inventory_id")]
    internal class Inventory
    {
        public int inventory_id { get; set; }
        public int film_id { get; set; }
        public int store_id { get; set; }
        public DateTime last_update { get; set; }
    }
}
