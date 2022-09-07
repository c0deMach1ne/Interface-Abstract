/*
 * ### SENARYO ###
 * 
 * Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
 * Starbucks ve Kahve Dükkanı firmaları için çalışıyoruz.
 * İki firma da müşterilerini veri tabanına kaydetmek istiyor.
 * Starbucks müşterileri kaydederken, mutlaka Mernis doğrulaması istiyor. Kahve Dükkanı müşterileri kaydederken böyle bir şey istemiyor.
 * Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
 * 
 * ÖNEMLİ NOT: Mernis servisini kullanabilmek için aşağıdaki işlemlerin yapılması gerekmektedir. Aksi takdirde servisi kullanamayız.
 * (Hali hazırda bu proje için yüklemenize gerek yok ancak sıfır bir proje başlatıyorsanız bunları yapmanız gerekmektedir.)
 * "Solution Explorer" penceresinden "Interface_Abstract" yazan projemize sağ tuş tıklayıp "Add > Service Reference..." seçeneğini seçiyoruz.
 * Açılan pencereden "WCF Web Service" isimli seçeneğini seçiyoruz ve "Next" butonuna basıyoruz.
 * "URI:" yazısının altındaki kutucuğa "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?op=TCKimlikNoDogrula" linkini yapıştırıyoruz.
 * "Namespace" yazısının altındaki kutucuğa "MernisServiceReference" yazıyoruz. (Namespace servisimizin namespace ismi olacak. Farklı bir şey de yazabilirsiniz.)
 * Ve "Go" butonuna basıyoruz.
 * Biraz bekledikten sonra "Next" butonuna basıyoruz ve karşımıza çıkan tüm pencereleri "Next" butonuna basarak ilerletiyoruz.
 * "Finish" butonuna gördüğümüzde butona basıyoruz ve işlem tamamlandı. 
 */

using Interface_Abstract.Abstract;

/*
 * Factory Method Pattern için kullandığımız Creater sınıfından bir instance oluşturduk.
 * Oluşturduğumuz instance'ın "FactoryMethod" isimli metodunu çalıştırarak "BaseCustomerManager" sınıfından bir instance oluşturduk.
 * "Firmalar." yazarak Enumaration sayesinde hangi firma olduğunu belirledik ve ona göre işlem yapılmasını sağladık.
 */
Creater creater = new Creater();
BaseCustomerManager customerManager = creater.FactoryMethod(Firmalar.Starbucks);

// Factory Method Pattern kullanmak istemezsek aşağıdaki yöntem ile StarbucksCustomerManager'dan bir instance üretebiliriz.
//BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

Console.WriteLine("Kimlik bilgilerinizi girerek doğrulama işlemini yapın.");

Console.Write("Adınız: ");
string firstName = Console.ReadLine();

Console.Write("Soyadınız: ");
string lastName = Console.ReadLine();

Console.Write("Doğum Yılınız: ");
int dateOfBirth = Convert.ToInt32(Console.ReadLine());

Console.Write("T.C. Kimlik Numaranız: ");
string citizenId = Console.ReadLine();

customerManager.SaveToDb(new Customer
{
    CitizenId = citizenId,
    FirstName = firstName,
    LastName = lastName,
    DateOfBirth = dateOfBirth
});

Console.ReadLine();