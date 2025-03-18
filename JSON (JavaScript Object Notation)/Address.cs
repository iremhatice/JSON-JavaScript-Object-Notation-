using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSON__JavaScript_Object_Notation_
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        // JsonIgnore ile serileştirilmek istenmeyen bir özellik ekliyoruz
        [JsonIgnore]
        public string Country { get; set; }
    }
}
