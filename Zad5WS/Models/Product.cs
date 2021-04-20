using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad5WS.Models
{
    public class Product
    {
        [Required]
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string Maker { get; set; }
        [Required]
        [MaxLength(200)]
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string Url { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
       

    }
}
