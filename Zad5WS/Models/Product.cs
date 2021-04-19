using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Zad5WS.Models
{
    public class Product
    {

        public string Id { get; set; } 
        [Required]
        
        public string Maker { get; set; }
        [Required]
        [MaxLength(20)]
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [Required]
        [MaxLength(20)]
        public string Url { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
        

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
       

    }
}
