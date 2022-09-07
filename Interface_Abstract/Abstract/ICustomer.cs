using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Abstract
{
    /*
     * Hem "Starbucks" firması hem de "Kahve Dükkanı" firması müşteri bilgilerini veritabanına kaydedeceği için
     * yani ortak bir işlem olduğundan dolayı "ICustomer" isminde bir interface oluşturduk.
     * Bu tanımladığımız interface içerisine "SaveToDb" isminde bir void tanımladık.
     * Bu void'in amacı "Customer" sınıfındaki müşteri bilgisini veritabanına kaydetmektir.
     * Burada dikkat edilmesi gereken nokta 2 firma da kayıt işlemi yapacak ancak Starbucks firması kayıt etmeden önce kişinin kimlik bilgilerini Mernis ile
     * doğrulama yaptıktan sonra veritabanına kayıt işlemini yapacaktır. Ancak Kahve dükkanı sadece kaydedecektir.
     * Burada sadece tanımlama işlemi gerçekleştiriyoruz.
     * Veritabanına kaydetme ile alakalı kodlarımızı ilgili classların içerisine override yaparak yazacağız.
     */
    public interface ICustomer
    {
        void SaveToDb(Customer customer);
    }
}
