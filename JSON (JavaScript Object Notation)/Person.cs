using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSON__JavaScript_Object_Notation_
{
    public class Person
    {
        // JsonConstructor, sınıfın özel bir yapıcı metodunun (constructor) JSON'dan deserialization sırasında kullanılmasını sağlar.
        [JsonConstructor]
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Bir sınıf özelliğini JSON'da farklı bir isimle serileştirmek veya deserialization yapmak için kullanılır.
        [JsonProperty("FullName")]
        public string Name { get; set; }
        public int Age { get; set; }

        // JSON'da adres bilgilerini "address" olarak serileştirir
        [JsonProperty("address")]
        public Address Address { get; set; }
    }

}
