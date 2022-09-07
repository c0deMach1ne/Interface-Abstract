using Interface_Abstract.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Concrete
{
    /*
     * Starbucks firması için gerekli olan "StarbucksCustomerManager" isimli sınıfımızı oluşturduk ve "BaseCustomManager" sınıfından kalıtım aldırdık.
     * Kalıtım alarak "SaveToDb" metoduna erişmiş olduk.
     * "override" anahtar kelimesini kullanarak ilgili "SaveToDb" metodunu ezdik ve isteğimize göre metodu özelliştirme özelliğine sahip olduk.
     * Yani Kahve Dükkanı için müşteri bilgilerini veritabanına direkt gönderirken, Starbucks için bir mernis onayı yapacağız.
     * Aynı metot ama 2 farklı senaryo yapmamıza olanak sağlayan burada "override" anahtar kelimesi oluyor.
     * Aynı işlemi "KahveDukkaniCustomerManager" sınıfı içinde yaptık.
     * İsteseydik bu sınıf içerisinde Mernis onayını gerçekleştirebilirdik ancak olası bir durumda diyelim ki Kahve Dükkanı firması da bizden Mernis onayını bizde istiyoruz
     * gibi bir talepte bulunursa ona göre işlem yapmalıyım. O yüzden bu senaryoya göre yola çıkacak olursak burada kontrol etmek yerine
     * "ICustomerCheck" isminde bir interface tanımladık.
     * Daha sonrasında bu interface'den kalıtım almak yerine bu sefer "Dependency Injection" yöntemi ile "_customerCheck" isimli "ICustomerCheck" tipinde bir değişken tanımladık.
     * Daha sonrasında ise "StarbucksCustomerManager" isimli sınıfımızdan oluşturduğumuz boş constructor'ın içerisindeki
     * "_customerCheck" isimli değişkenimize "ICustomerCheck" interface'ini gönderdik.
     * Artık program.cs içerisinde;
     * BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
     * yada
     * BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
     * yazarak ister Mernis servisi için oluşturduğumuz sınıfı
     * istersek de bir yere bağlı olmayan ve özelleştirebileceğimiz "CustomerCheckManager" sınıfını da gönderebiliriz.
     * Özetle mernisin alt yapısı bir sebepten dolayı ulaşılamaz durumda olsa bile kod yapımızı bozmadan kendi özelleştirebildiğimiz servisimizi de kullanabiliriz.
     */
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheck _customerCheck;

        public StarbucksCustomerManager(ICustomerCheck customerCheck)
        {
            _customerCheck = customerCheck;
        }

        public override void SaveToDb(Customer customer)
        {
            if (_customerCheck.CheckPerson(customer))
                base.SaveToDb(customer);
            else
                Console.WriteLine("Bu kimlik bilgileri geçerli değil!");
        }
    }
}
