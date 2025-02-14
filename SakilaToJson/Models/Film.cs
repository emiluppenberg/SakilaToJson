using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson.Models
{
    [PrimaryKey("film_id")]
    internal class Film
    {
        public int film_id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string release_year { get; set; } = string.Empty;
        public byte language_id { get; set; }
        public byte? original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; } = string.Empty;
        public string special_features { get; set; } = string.Empty;
        public DateTime last_update { get; set; }
    }
}
