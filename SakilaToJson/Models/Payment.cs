using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson.Models
{
    [PrimaryKey("payment_id")]
    internal class Payment
    {
        public int payment_id { get; set; }
        public int customer_id { get; set; }
        public byte staff_id { get; set; }
        public int? rental_id { get; set; }
        public decimal amount { get; set; }
        public DateTime payment_date { get; set; }
        public DateTime last_update { get; set; }
    }
}
