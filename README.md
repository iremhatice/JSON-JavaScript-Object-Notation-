# JSON İşlemleri Projesi

Bu proje, JSON serileştirme ve deserialization işlemlerini gerçekleştiren bir C# uygulamasıdır. JSON verileriyle çalışırken kullanılan temel ve ileri düzey özellikleri anlamanızı sağlayacak örnekler içermektedir. Proje, **Newtonsoft.Json** kütüphanesini kullanarak JSON verisi ile işlem yapmayı hedefler.

## İçerik
- **Serileştirme (Serialization)**: Nesneleri JSON formatına dönüştürme.
- **Deserialization**: JSON string'ini nesneye dönüştürme.
- **JsonConstructor**: JSON'dan özel yapıcı metodlarla nesne oluşturma.
- **JsonConverter**: Özelleştirilmiş dönüşüm işlemleri (Örneğin, tarih formatları).
- **JsonIgnore**: Belirli özellikleri serileştirme dışı bırakma.
- **JsonIgnoreCondition**: Null değerlerini serileştirmemek için kullanılır.
- **JsonSerializerSettings**: JSON serileştirme işlemleri için özelleştirilmiş ayarlar.

## Proje Yapısı

- **JsonHandler.cs**: JSON serileştirme ve deserialization işlemlerini yapan sınıf.
- **Person.cs**: Person sınıfı ve JSON özellikleri.
- **Address.cs**: Address sınıfı ve JSON özellikleri.
- **PersonWithIgnoreCondition.cs**: `JsonIgnoreCondition` özelliği ile null değerleri dışlamak için kullanılan sınıf.
- **CustomDateConverter.cs**: `DateTime` türü için özel tarih formatları ile serileştirme ve deserialization işlemi.
- **Program.cs**: JSON işlemlerini test eden ana program.
