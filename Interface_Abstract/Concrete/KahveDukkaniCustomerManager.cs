using Interface_Abstract.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Concrete
{
    /*
     * Kahve Dükkanı firması için gerekli olan "KahveDukkaniCustomerManager" isimli sınıfımızı oluşturduk ve "BaseCustomManager" sınıfından kalıtım aldırdık.
     * Kalıtım alarak "SaveToDb" metoduna erişmiş olduk.
     * "override" anahtar kelimesini kullanarak ilgili "SaveToDb" metodunu ezdik ve isteğimize göre metodu özelliştirme özelliğine sahip olduk.
     * Yani Kahve Dükkanı için müşteri bilgilerini veritabanına direkt gönderirken, Starbucks için bir mernis onayı yapacağız.
     * Aynı metot ama 2 farklı senaryo yapmamıza olanak sağlayan burada "override" anahtar kelimesi oluyor.
     */
    public class KahveDukkaniCustomerManager : BaseCustomerManager
    {
        public override void SaveToDb(Customer customer)
        {
            base.SaveToDb(customer);
        }
    }
}
