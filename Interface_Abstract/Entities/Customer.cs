using Interface_Abstract.Abstract;

/*
 * Tüm müşteri bilgilerini alıp işleme sokacağımız "Customer" isimli sınıfımızı oluşturduk.
 * "IEntity" ismindeki Interface'den kalıtım aldırdık.
 * Müşteri bilgilerini hem Get hem de Set işlemi yapabileceğimizi belirterek ihtiyacımız olan "Property" nesnelerini tanımladık.
 * 
 * ### Property Nedir? ###
 * Bir class içerisinde bulunan bazı alanlara her zaman ulaşmak gerekmeyebilir.
 * Çünkü bir nesneyi sürekli ulaşılabilir hale getirmek bilinçsiz bir kullanım, veri kaybı ve güvenlik gibi sorunları ortaya çıkartabilir.
 * Nesnelerin "private" erişim belirleyicisi yazılarak tanımlanmasının sebebi bu tip gerekçelerden kaynaklanmaktadır.
 * "Public" erişim belirleyicisi ise o nesneyi tamamen açık ve ulaşılabilir bir hale getirir. İşte tam nu noktada nesnelerimizin erişimini yönetmek için
 * "Property" kavramı devreye girer. "Property" yani Özellik metotları nesnelerimiz üzerinde kontrollü kullanım sağlamaktadır.
 * 
 * ### Get ve Set Nedir? ###
 * Property'nin 2 yordamı vardır. Bunlardan biri "Get" bir diğeri de "Set" anahtar kelimesidir.
 * "Get": İlgili nesnenin değerini geri döndürür.
 * "Set": İlgili nesnenin değerini değiştirmemizi sağlar.
 * 
 * Ekstra bilgi: Get ve Set metotları içerisinde "If-Else" gibi karar yapıları ve "For" gibi döngü çeşitlerini kullanabilmemize olanak sağlar.
 * > Örnek:
 * public short Age {
        get { return Age; }
        set {
            if (Age < 18)
                Console.WriteLine("18 yaşından küçüksünüz.");
            else
                Console.WriteLine("18 yaşından büyüksünüz.");
        }
    }
 */
public class Customer : IEntity
{
    public int Id { get; set; }
    public string CitizenId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DateOfBirth { get; set; }
}