using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSON__JavaScript_Object_Notation_
{
    public class PersonWithIgnoreCondition
    {
        public string Name { get; set; }

        // JSON serileştirmesinde null değerlerin hariç tutulması için JsonIgnoreCondition kullanabiliriz.Newtonsoft.Json kullandığımızdan dolayı JsonIgnore kullandık.
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonIgnore]
        public int? Age { get; set; }  // Null değeri olduğunda serileştirilmeyecek
    }
}
