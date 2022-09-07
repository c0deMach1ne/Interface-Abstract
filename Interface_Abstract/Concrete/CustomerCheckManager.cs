using Interface_Abstract.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Concrete
{
    /*
     * "CustomerCheckManager" isminde bir class oluşturduk ve "ICustomerCheck" ismindeki interface'den kalıtım aldık.
     * "ICustomerCheck" isimli interface için implement işlemi yaptık ve interface içerisindeki "CheckPerson" fonksiyonunu
     * "CustomerCheckManager" sınıfının içerisine implement etmiş olduk.
     * Bu yapı tamamen özelleştirilebilir bir yapı olması için oluşturuldu.
     * "return true;" diyerek her türlü müşterinin kimlik onayından geçmesini sağladık.
     * Yani bir sebepten dolayı Mernis sisteminin alt yapısından oluşabilecek herhangi bir bağlantı sorununda uygulamamızın tamamen hata vermesi yerine
     * bu şekilde özelleştirilebilir yapıyı kullanarak hataları giderebiliriz veya mernis alt yapısı gitse bile test amaçlı olarak da kullanabiliriz.
     */
    public class CustomerCheckManager : ICustomerCheck
    {
        public bool CheckPerson(Customer customer)
        {
            return true;
        }
    }
}
