using static System.Net.Mime.MediaTypeNames;

#region Değişkenler

bas:
int x;
int y;
int z = 0;
int e = 0;
int d = 0;
string cikis;
string girdi2;
string topla = "+";
string cikar = "-";
string carp = "*";
string bol = "/";

#endregion

#region Giriş Ekranı

Console.WriteLine("Hesap makinesinde 2 sayıyla işlem yapmak istiyorsanız 2'ye, \n 3 sayıyla işlem yapmak istiyorsanız 3'e, \n 4 sayıyla işlem yapmak istiyorsanız 4'e, \n 5 sayıyla işlem yapmak istiyorsanız 5'e,\n Uygulamadan çıkmak istiyorsanız ise q tuşuna basınız.");
cikis = Convert.ToString(Console.ReadLine());
if (cikis == "2")
{
    goto hesapmakinesi;
}
if (cikis == "3")
{
    goto hesapmakinesi;
}
if (cikis == "4")
{
    goto hesapmakinesi;
}
if (cikis == "5")
{
    goto hesapmakinesi;
}
if (cikis == "q")
{
    Environment.Exit(0);
}

#endregion

#region Sayı Giriş Ekranı Ve İşlem Seçimi

hesapmakinesi:
Console.WriteLine("1. Sayıyı Giriniz");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz");
y = Convert.ToInt32(Console.ReadLine());
if (cikis == "2")
{
    goto islem;
}
Console.WriteLine("3. Sayıyı Giriniz");
z = Convert.ToInt32(Console.ReadLine());
if (cikis == "3")
{
    goto islem;
}
Console.WriteLine("4. Sayıyı Giriniz");
e = Convert.ToInt32(Console.ReadLine());
if (cikis == "4")
{
    goto islem;
}
Console.WriteLine("5. Sayıyı Giriniz");
d = Convert.ToInt32(Console.ReadLine());
islem:
Console.WriteLine("Hangi İşlemi Yapmak İstersiniz? \n Toplama = + \n Çıkarma = - \n Çarpma = *  \n Bölme = / \n Üs Alma = ^");
girdi2 = Convert.ToString(Console.ReadLine());

#endregion

#region İşlemleri Tanımlama

int toplam = 0;
int cikarma = 0;
int carpim = 0;
int bolum = 0;
double usalma = Math.Pow(x,y);

if (cikis == "2")
{
    toplam = x + y;
    cikarma = x - y;
    carpim = x * y;
    bolum = x / y;
}
if (cikis == "3")
{
    toplam = x + y + z;
    cikarma = x - y - z;
    carpim = x * y * z;
    bolum = x / y / z;
}
if (cikis == "4")
{
    toplam = x + y + z + e;
    cikarma = x - y - z - e;
    carpim = x * y * z * e;
    bolum = x / y / z / e;
}
if (cikis == "5")
{
    toplam = x + y + z + e + d;
    cikarma = x - y - z - e - d;
    carpim = x * y * z * e * d;
    bolum = x / y / z / e / d;
}

#endregion

#region Sonucu Ekrana Yazdırma

if (girdi2 == topla)
{
    Console.Write(toplam);

}
else if (girdi2 == cikar)
{
    Console.Write(cikarma);
}
else if (girdi2 == carp)
{
    Console.Write(carpim);
}
else if (girdi2 == bol)
{
    Console.Write(bolum);
}
else
{
    Console.Write(usalma);
}
Console.WriteLine("\n");
goto bas;

#endregion