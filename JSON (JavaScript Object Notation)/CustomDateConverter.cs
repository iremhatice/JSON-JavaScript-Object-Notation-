using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON__JavaScript_Object_Notation_
{
    //Özel veri türleri ile çalışırken (örneğin, tarih veya özel sınıf nesneleri), JsonConverter kullanarak serileştirme ve deserialization işlemlerini özelleştirebilirsiniz. Bu, JSON'dan alınan verileri özel bir şekilde işlemek için gereklidir.
    public class CustomDateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // DateTime değerini özel formatta JSON'a yazma
            writer.WriteValue(((DateTime)value).ToString("yyyy-MM-dd"));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // JSON'dan tarih değerini özel formatta DateTime'a dönüştürme
            return DateTime.ParseExact((string)reader.Value, "yyyy-MM-dd", null);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime); // Sadece DateTime türü için geçerli
        }
    }
}
