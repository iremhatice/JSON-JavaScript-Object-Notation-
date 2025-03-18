using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace JSON__JavaScript_Object_Notation_
{
    public class JsonHandler
    {
        // Nesneyi JSON formatına serileştiren metot
        public string Serialize(object obj)
        {
            try
            {
                // Serileştirme ve deserialization işlemlerini özelleştirmek için, JsonSerializerSettings kullanabilirsiniz. Örneğin, tarih formatını değiştirebilir veya boş değerleri yoksayabilirsiniz.
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,   // Formatting.Indented, JSON'u daha okunabilir yapmak için kullanılır
                    NullValueHandling = NullValueHandling.Ignore // Null değerleri serileştirmiyoruz
                };

                //Bir nesneyi JSON formatına dönüştürmek için kullanılır. Bu işlem serileştirme olarak bilinir ve nesnenin içeriğini bir JSON string'ine dönüştürür.
                return JsonConvert.SerializeObject(obj, settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serileştirme hatası: " + ex.Message);
                return null;
            }
        }

        // JSON string'ini nesneye dönüştüren metot
        public T Deserialize<T>(string json)
        {
            try
            {
                // DeserializeObject(), bir JSON string'ini C# nesnesine dönüştürmek için kullanılır. Bu işlem deserialization olarak bilinir ve JSON verisini, belirtilen türde bir nesneye dönüştürür.
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                // Deserialization sırasında bir hata oluşursa, hata mesajını ekrana yazdırıyoruz
                Console.WriteLine("Deserialization hatası: " + ex.Message);
                return default(T); // Hata durumunda varsayılan değer döndürülür
            }
        }
    }
}
