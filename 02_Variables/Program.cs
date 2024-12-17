using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region double degiskenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.54;
            //strawberryPrice = 48;
            //potatoPrice = 9.56;
            //tomatoPrice = 3.68;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.678;
            //strawberryGram = 0.682;
            //potatoGram = 4.589;
            //tomatoGram = 3.546;

            //double appleTotalPrice = applePrice * appleGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double orangeTotalPrice = orangePrice * orangeGram;

            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Ücret:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün:Portakal - " + "Birim Fiyat:" + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Ücret:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün:Çilek - " + "Birim Fiyat:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Ücret:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün:Patates - " + "Birim Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Ücret:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün:Domates - " + "Birim Fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Ücret:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice + orangeTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "₺");


            #endregion

            #region char degiskenler

            //char symbol;

            //symbol = 'a';


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber + " Yolcu Adı Soyadı: "+ passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);




            #endregion

            #region Klavyeden Tam sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 5000;
            //chairPrice = 6000;
            //tvPrice = 10000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice +  tvPrice * tvCount;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, result,exam3;

            //Console.Write("Lütfen Birinci Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız" + result);




            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);




            #endregion
            Console.Read();
        }
    }
}
