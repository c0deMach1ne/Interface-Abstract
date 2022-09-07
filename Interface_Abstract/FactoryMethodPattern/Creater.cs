using Interface_Abstract.Abstract;
using Interface_Abstract.Adapters;
using Interface_Abstract.Concrete;
using System.Reflection;

/*
 * Factory Method Pattern kullanabilmek için "Creater" isminde bir sınıf oluşturduk.
 * Enumaration sayesinde "Firmalar" isminde bir enum oluşturduk ve içerisine "KahveDukkani ve Starbucks" firmalarını gönderdik.
 * "BaseCustomerManager" tipinde "FactoryMethod" isminde bir fonksiyon oluşturduk.
 * İçerisine dışarıdan göndereceğimiz "Firmalar" enumunu gönderdik.
 * "BaseCustomerManager" sınıfından "baseCustomerManager" isimli ve null olan bir değişken tanımladık.
 * "switch" anahtar kelimesini kullanarak dışarıdan enum sayesinde gönderdiğimiz firmayı yakalattık.
 * "case" anahtar kelimesi ile de gönderdiğimiz firmaya göre tek tek ele alıp ilgili firmaya göre bir instance oluşturduk.
 * "baseCustomerManager = new KahveDukkaniCustomerManager();" herhangi bir doğrulama olmadan oluşturmamızı sağladı.
 * "baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());" MernisServiceAdapter sayesinde Mernis doğrulaması yapacağımızı belirttik.
 * En sonda ise "return baseCustomerManager;" diyerek oluşturulan instance'ı geri döndürdük.
 * Artık program.cs üzerinden Creater sınıfının FactoryMethod isimli fonksiyonunu kullanarak seçtiğimiz firmaya ait sınıftan yeni instance oluşturabiliriz.
 */

enum Firmalar
{
    KahveDukkani,
    Starbucks
}

class Creater
{
    public BaseCustomerManager FactoryMethod(Firmalar firma)
    {
        BaseCustomerManager baseCustomerManager = null;

        switch (firma)
        {
            case Firmalar.KahveDukkani:
                baseCustomerManager = new KahveDukkaniCustomerManager();
                break;
            case Firmalar.Starbucks:
                baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
                break;
        }

        return baseCustomerManager;
    }
}
