using Interface_Abstract.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract.Adapters
{
    /*
     * Mernis onaylama işlemi için gerekli olan "MernisServiceAdapter" isimli sınıfımızı oluşturduk ve "ICustomerCheck" isimli interface'den kalıtım aldık.
     * Kalıtım aldığımız için "ICustomerCheck" isimli interface içerisindeki "CheckPerson" isimli bool fonksiyonunu implement ettik.
     * Daha sonrasında Mernis'in servisini kullanarak doğrulama işlemini gerçekleştirdik.
     * "return" anahtar kelimesi sayesinde geri dönen işlem sonucunu yakalattık ve fonksiyon işlemini tamamladı.
     */
    public class MernisServiceAdapter : ICustomerCheck
    {
        public bool CheckPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.CitizenId), customer.FirstName, customer.LastName, customer.DateOfBirth);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
