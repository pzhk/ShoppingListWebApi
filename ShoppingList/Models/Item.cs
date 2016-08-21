using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class Item
    {
        [JsonIgnore]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
    }
}