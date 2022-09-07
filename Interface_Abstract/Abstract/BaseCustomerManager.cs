using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Abstract
{
    /*
     * "BaseCustomManager" isminde bir class oluşturduk ve "ICustomer" ismindeki interface'den kalıtım aldık.
     * "ICustomer" isimli interface için implement işlemi yaptık ve interface içerisindeki "SaveToDb" metotunu "BaseCustomManager" sınıfının içerisine implement etmiş olduk.
     */
    public abstract class BaseCustomerManager : ICustomer
    {
        public virtual void SaveToDb(Customer customer)
        {
            Console.WriteLine($"\n{customer.FirstName} {customer.LastName} isimli müşterinin kimlik bilgileri onaylandı ve veritabanına kaydedildi!");
        }
    }
}
