using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constant (Sabitler)

            //const double pi = 3.14;

            /* this is mistake because age is declared
            const int age;
            const int new_age = 20 * age;
            */

            //int diameter = 3;
            //double area = pi * Math.Pow(diameter, 2);
            //double radius = 2 * pi * diameter;

            //Console.WriteLine("Cap: " + diameter);
            //Console.WriteLine("Alan: " + area);
            //Console.WriteLine("Çevre: " + radius);

            #endregion

            #region Conditionals IF-ELSE IF-ELSE
            //IF-ELSE
            //int vize, final;
            //double donemSonuPuanı;

            //Console.Write("Vize notunuzu giriniz:");
            //vize = int.Parse(Console.ReadLine());


            //Console.Write("Final notunuzu giriniz:");
            //final = int.Parse(Console.ReadLine());

            //donemSonuPuanı = vize * 0.4 + final * 0.6;

            //if (donemSonuPuanı <= 50)
            //{
            //    Console.WriteLine("NOTUNUZ: " + donemSonuPuanı + " KALDINIZ!");
            //}

            //else {
            //    Console.WriteLine("NOTUNUZ: "+ donemSonuPuanı+ " GEÇTİNİZ! ");
            //}

            //IF-ELSE IF

            //int havaSıcaklıgı;

            //Console.Write("Lütfen hava sıcaklığını giriniz: ");
            //havaSıcaklıgı = int.Parse(Console.ReadLine());

            //if (havaSıcaklıgı < 0)
            //{
            //    Console.WriteLine("Don olayı yaşanabilir!");
            //}
            //else if (havaSıcaklıgı <= 15)
            //{
            //    Console.WriteLine("Hava soğuk!");
            //}
            //else if (havaSıcaklıgı <= 25)
            //{
            //    Console.WriteLine("Hava ılık!");
            //}
            //else if (havaSıcaklıgı <= 60)
            //{
            //    Console.WriteLine("Hava çok sıcak!");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz sıcaklık değeri yaptınız!");
            //}




            #endregion

            #region Conditional SWITCH-CASE
            //SWITCH-CASE

            //int day = (int)DateTime.Now.DayOfWeek;
            //switch (day)
            //{
            //    case 1: Console.WriteLine("Today is Monday"); break;
            //    case 2: Console.WriteLine("Today is Tuesday"); break;
            //    case 3: Console.WriteLine("Today is Wednesday"); break;
            //    case 4: Console.WriteLine("Today is Thursday"); break;
            //    case 5: Console.WriteLine("Today is Friday"); break;
            //    case 6: Console.WriteLine("Today is Saturday"); break;
            //    case 7: Console.WriteLine("Today is Sunday"); break;
            //    default:
            //        break;
            //}

            //Console.Write("Kaçıncı ayda olduğunuzu giriniz: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış mevsimindesiniz!");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar mevsimindesiniz!");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz mevsimindesiniz!");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar mevsimindesiniz!");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı ay girişi yaptınız!");
            //        break;
            //}

            //int num1, num2,sum;
            //char symbol;

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //num2= int.Parse(Console.ReadLine());

            //Console.WriteLine("'+'-> Toplama ");
            //Console.WriteLine("'-'-> Çıkarma ");
            //Console.WriteLine("'*'-> Çarpma ");
            //Console.WriteLine("'/'-> Bölme ");
            //Console.Write("Lütfen yapmak istediğiniz işlemi geçiniz: ");
            //symbol= char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        sum = num1 + num2;
            //        Console.WriteLine("Toplama işleminin sonucu: " +sum);
            //        break;
            //    case '-':
            //        sum = num1 - num2;
            //        Console.WriteLine("Çıkarma işleminin sonucu: " + sum);
            //        break;
            //    case '*':
            //        sum = num1 * num2;
            //        Console.WriteLine("Çarpma işleminin sonucu: " + sum);
            //        break;
            //    case '/':
            //        sum = num1 /num2;
            //        Console.WriteLine("Bölme işleminin sonucu: " + sum);
            //        break;
            //    default: Console.WriteLine("Hatalı işlem girişi yapıldı!");
            //        break;
            //}
            #endregion

            #region FOR LOOPS:
            //int tekToplam = 0;
            //int ciftToplam=0;

            //for (int i = 1; i <=10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("çift sayi:" +i);
            //        ciftToplam += i;
            //    }
            //    else {
            //        Console.WriteLine("tek sayi:" + i);
            //        tekToplam += i;
            //    }

            //}

            //Console.WriteLine("Cift Sayıların Toplamı: " + ciftToplam);
            //Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
            #endregion

            #region WHILE LOOPS

            //int sayac = 10;

            //while (sayac <= 100) {
            //    Console.WriteLine("SAYAC: " +sayac);
            //    sayac += 10;
            //}

            //int sayac = 100;

            //while (sayac >= 10)
            //{
            //    Console.WriteLine("SAYAC: " + sayac);
            //    sayac -= 10;
            //}

            //int number = 1;
            //while (number < 10)
            //{
            //    Console.WriteLine("Sayı 10'a ulaşmadı degeri: "+ number);
            //    number++;
            //}
            //Console.WriteLine("sayınız 10 oldu :) ");




            #endregion

            #region DO-WHILE LOOPS:

            //int age = 0;
            //do
            //{
            //    age++;
            //    Console.WriteLine("sevval' age: " + age);
            //}
            //while (age <= 22);

            //int number = 0;
            //int sum = 0;

            //do
            //{
            //    Console.Write("Cift sayi giriniz: ");
            //    number = int.Parse(Console.ReadLine());

            //    if (number % 2 == 1) break;
            //    sum += number;
            //}

            //while (true);
            //Console.WriteLine("Cift sayiların toplamı: "+sum);

            //Random r = new Random();
            //int rs = 0;
            //int s;
            //rs = r.Next(1, 10);

            //do
            //{
            //    Console.Write("Sayi giriniz: ");
            //    s = int.Parse(Console.ReadLine());

            //    if (s < rs)
            //    {
            //        Console.WriteLine("Buyuk sayi giriniz!");
            //    }
            //    else if (s > rs)
            //    {
            //        Console.WriteLine("Küçük sayı giriniz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("TEBRIKLER BILDINIZ!");
            //    }
            //}


            //while (s != rs);

            //string name;
            //int sayac = 0;

            //Console.Write("Adınızı giriniz: ");
            //name=Console.ReadLine();

            //do
            //{
            //    Console.WriteLine(name[sayac]);
            //    sayac++;
            //} 

            //while (sayac<= name.Length);



            #endregion

            #region FOREACH LOOPS:

            //string[] names = { "SEVVAL TORUN", "BURAK COLAK", "FATIH SAMED TIMUR", "AYSEM YILDIZ", "EMIR TOLGUN", "FURKAN BIKMAZ", "SEVDA GOKSEL" };

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(27);
            //arrayList.Add(22);
            //arrayList.Add(28);
            //arrayList.Add(2);
            //arrayList.Add(13);
            //arrayList.Add(8);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] days = new string[7];
            //days[0] = "MONDAY";
            //days[1] = "TUESDAY";
            //days[2] = "WEDNESDAY";
            //days[3] = "THURSDAY";
            //days[4] = "FRIDAY";
            //days[5] = "SATURDAY";
            //days[6] = "SUNDAY";

            //foreach (var item in days)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Math Fonc.
            //mutlak değer:

            //int num = -50;
            //int newNum= Math.Abs(num);
            //Console.WriteLine("Num: " + num + " |Num|: " + newNum);

            ////yukarı yuvarlama: 
            //double a=9.3;
            //double newA = Math.Ceiling(a);
            //Console.WriteLine(newA);

            ////e'nin kuvvetini hesaplar
            //double number = Math.Exp(3);
            //Console.WriteLine(number);

            //aşağı yuvarlama
            //double b = 9.8;
            //double newB=Math.Floor(b);
            //Console.WriteLine(newB);


            //double big = Math.Max(12,567);
            //Console.WriteLine(big);
            //double min = Math.Min(12, -13);
            //Console.WriteLine(min); 

            //double yariCap = 2;
            //double alan= Math.PI* Math.Pow(2, yariCap);
            //Console.WriteLine("Alan: " + alan);

            //double sayi= 12.2456734;
            //double ayarla = Math.Round(sayi,4);
            //Console.WriteLine(ayarla);

            //double number = 625;
            //double kok= Math.Sqrt(number);
            //Console.WriteLine(kok);

            //Console.WriteLine("Bulmak istediğiniz derecdeyi giriniz: ");
            //double derece = double.Parse(Console.ReadLine());

            //Console.WriteLine("Derecenin Sinüsü:" + Math.Sin((Math.PI*derece)/180));
            //Console.WriteLine("Derecenin Cosinüsü:" + Math.Cos((Math.PI*derece)/180));
            //Console.WriteLine("Derecenin Tanjantı:" + Math.Tan((Math.PI*derece)/180));

            Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int number = random.Next(1, 10);//10 dahil değil sadece 
            //    Console.WriteLine(number);
            //}
            //double number = random.NextDouble();    
            //Console.WriteLine(number);

            //int ascii = random.Next(65, 91);
            //char karakter = Convert.ToChar(ascii);
            //Console.WriteLine(karakter);    

            //string harfler = "ABCDEFGHIİJKLMNOÖPRSŞTUÜVYZabcçdefghhıijklmnoöprsştuüvzy";
            //string uret = "";
            //for (int i = 0; i < 8; i++)
            //{
            //    uret += harfler[random.Next(harfler.Length)];
            //}
            //Console.WriteLine(uret);


            //PAROLA ÜRET!!!

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                int ascii = random.Next(32, 127);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            Console.WriteLine(sb.ToString());


            #endregion
            Console.Read();

        }
    }
}
