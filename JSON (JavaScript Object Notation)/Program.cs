namespace JSON__JavaScript_Object_Notation_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Json Ile Ilgili Temel Bilgiler
            /*
             Json Nedir?
                JSON (JavaScript Object Notation), veri iletimi ve depolanmasında yaygın olarak kullanılan hafif, insan tarafından okunabilir bir veri formatıdır. JSON, genellikle API'lerde veri gönderimi için kullanılır. JSON, nesne ve dizileri (array) temsil edebilen, anahtar-değer çiftlerinden oluşur. C#’ta JSON serileştirme ve deserialization işlemleri için genellikle Newtonsoft.Json kütüphanesi kullanılır. Bu kütüphane, JSON verilerini kolayca işleyebilmek için geniş bir API sunar.
                *  Nesne (Object): { "key": "value" } şeklinde anahtar-değer çiftlerinden oluşur.
                *  Dizi (Array): [ "value1", "value2", "value3" ] şeklinde sıralı bir veri yapısıdır.
                *  Veri Tipleri: String, number, boolean, null, array, object.
                
             JSON Serileştirme (Serialization) ve Serileştirme Çözme (Deserialization)
                Serileştirme (Serialization): Bir nesneyi ya da veri yapısını JSON formatına dönüştürme işlemidir. Bu işlemde, veriler JSON formatına uygun bir string haline getirilir.
                Deserialization: JSON formatındaki bir string'i, uygun veri yapısına (örneğin, bir nesne ya da dizi) dönüştürme işlemidir.

            Kullanım Alanları
               * API entegrasyonları: JSON, REST API'lerinde veri formatı olarak yaygın kullanılır.
               * Veri depolama: JSON, küçük veri setlerinin depolanmasında veya geçici verilerin saklanmasında kullanılabilir.      
              
            JSON ile Çalışan Kütüphaneler ve Araçlar
               * Newtonsoft.Json: Yaygın olarak kullanılan ve esnek bir JSON kütüphanesidir. JSON serileştirme ve deserialization işlemleri için güçlü bir API sağlar.
               * System.Text.Json: Microsoft tarafından sağlanan daha hafif ve performans odaklı bir JSON kütüphanesidir.
               * JSON Schema: JSON verisinin doğruluğunu kontrol etmek için kullanılan şemalar.
               * JsonPath: JSON verisinde veri aramak için kullanılan bir sorgulama dilidir. 
            
            Json Attribütler
               C#'ta JSON ile çalışırken, JSON verilerini serileştirme ve deserialization işlemlerini daha detaylı ve özelleştirilmiş bir şekilde yapmak için kullanabileceğiniz bazı önemli özellikler ve attribütler bulunmaktadır. Bu özellikler, Newtonsoft.Json (Json.NET) kütüphanesi ile birlikte kullanılır ve JSON veri işlemlerinde daha fazla esneklik sağlar.
               * JsonIgnore: Özellikleri serileştirmeden hariç tutmak için.
               * JsonProperty: JSON'daki anahtar adı ile sınıf özelliği arasında eşleştirme yapmak için.
               * JsonConstructor: Özelleştirilmiş yapıcı metodları kullanarak deserialization yapmak için.
               * JsonConverter: Özel veri türleri için serileştirme/deserialization işlemlerini özelleştirmek için.
               * JsonSerializerSettings: Serileştirme ayarlarını değiştirmek için kullanılabilir.
               * JsonSerializerOptions, C#’ta JSON serileştirme ve deserialization işlemleri için System.Text.Json kütüphanesi tarafından sağlanan bir sınıftır. Bu sınıf, JSON serileştiricisini özelleştirmek için kullanılır.
                       WriteIndented: JSON’un okunabilirliğini artırır.
                       PropertyNamingPolicy: JSON anahtarlarını küçük harfe dönüştürür (camelCase).
               * JsonIgnoreCondition, System.Text.Json kütüphanesinde, null değerlerin veya belirli koşullara göre özelliklerin serileştirilip serileştirilmeyeceğini kontrol etmek için kullanılır. Bu özellik, JsonSerializerOptions ile birlikte kullanılarak, belirli durumlarda JSON’a dahil edilmemesi gereken alanları kontrol etmek için çok kullanışlıdır.
             
               * Newtonsoft.Json kullanıyorsanız, JsonIgnore özelliğini kullanın.
                 System.Text.Json kullanıyorsanız, JsonIgnoreCondition'ı kullanabilirsiniz
             */
            #endregion


            JsonHandler jsonHandler = new JsonHandler();

            // JsonConstructor kullanarak Person nesnesi oluşturuyoruz
            Person person = new Person("Irem Kars", 25)
            {
                Address = new Address
                {
                    Street = "Şehit Sokak",
                    City = "İstanbul"
                }
            };

            // Nesneyi JSON formatına serileştiriyoruz
            string jsonString = jsonHandler.Serialize(person);
            Console.WriteLine("Serileştirilmiş JSON:");
            Console.WriteLine(jsonString);

            // JSON string'ini nesneye dönüştürüyoruz
            string jsonInput = "{\"Name\":\"Irem Kars\",\"Age\":25,\"address\":{\"Street\":\"Şehit Sokak\",\"City\":\"İstanbul\"}}";
            try
            {
                // Deserialize işlemi burada yapılır
                Person deserializedPerson = jsonHandler.Deserialize<Person>(jsonInput);
                Console.WriteLine("\nDeserialized Nesne:");
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Street: {deserializedPerson.Address.Street}, City: {deserializedPerson.Address.City}");
            }
            catch (Exception ex)
            {
                // Hata meydana gelirse, ekrana yazdırıyoruz
                Console.WriteLine("Deserialization hatası: " + ex.Message);
            }
        }
    }
}
