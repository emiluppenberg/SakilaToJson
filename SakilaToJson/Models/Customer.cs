using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson.Models
{
    [PrimaryKey("customer_id")]
    internal class Customer
    {
        public int customer_id { get; set; }
        public int store_id { get; set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public int address_id { get; set; }
        public char active { get; set; }
        public DateTime create_date { get; set; }
        public DateTime last_update { get; set; }
    }
}
