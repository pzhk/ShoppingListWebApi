using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class User
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String FamilyName { get; set; }
    }
}