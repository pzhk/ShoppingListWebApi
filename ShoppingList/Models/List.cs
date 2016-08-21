using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class List
    {
        public String UserId { get; set; }
        [JsonIgnore]
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Item> Items { get; set; }
    }
}