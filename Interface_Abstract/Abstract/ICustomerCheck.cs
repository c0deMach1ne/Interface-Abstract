using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Abstract
{
    /*
     * Hem "Starbucks" firması hem de "Kahve Dükkanı" firması müşteri bilgilerini veritabanına kaydetmeden önce Mernis doğrulaması yapabileceğinden dolayı
     * "ICustomerCheck" isminde bir interface oluşturduk.
     * Bu tanımladığımız interface içerisine "CheckPerson" isminde ve bool veri tipine sahip fonksiyon tanımladık.
     * Bu fonksiyonun amacı "Customer" sınıfındaki müşteri bilgilerini Mernis için kontrol etmektir.
     */
    public interface ICustomerCheck
    {
        public bool CheckPerson(Customer customer);
    }
}
