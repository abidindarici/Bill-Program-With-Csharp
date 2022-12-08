internal class Program
{
    private static void Main(string[] args)
    {
        string isim, vergi, ürün,birim;
        int birimfiyat, miktar, indirim, toplamfiyat, indirimlifiyat,sonfiyat,KDV,geneltoplam;
        Console.WriteLine("*************************");
        Console.WriteLine("Müşteri Bilgilerini Giriniz: ");
        Console.Write("İsim: ");
        isim = Console.ReadLine();
        Console.Write("Vergi No: ");
        vergi = Console.ReadLine();
        Console.WriteLine("Ürün Bilgilerini Giriniz: ");
        Console.Write("Ürün: ");
        ürün = Console.ReadLine();
        Console.Write("Birim Fiyat: ");
        birimfiyat = Convert.ToInt32(Console.ReadLine());
        Console.Write("Miktar: ");
        miktar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Birim Giriniz: ");
        birim = Console.ReadLine();
        Console.Write("İndirim Oranı Giriniz(%): ");
        indirim = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*************************");
        Console.WriteLine("ABİDİN MANAV A.Ş.");
        Console.WriteLine("-------------------------");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Müşteri : "+isim);
        Console.WriteLine("Vergi No : "+vergi);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Ürün Cinsi : "+ürün);
        toplamfiyat = birimfiyat*miktar;
        Console.WriteLine(miktar+" "+birim+" x "+birimfiyat+" = "+toplamfiyat+" ₺");
        indirimlifiyat = toplamfiyat*indirim/100;
        Console.WriteLine("İndirim ("+indirim+") :"+indirimlifiyat+" ₺");
        Console.WriteLine("-------------------------");
        sonfiyat = toplamfiyat-indirimlifiyat;
        Console.WriteLine("Toplam : "+sonfiyat);
        KDV = sonfiyat*18/100;
        Console.WriteLine("KDV(%18) : "+KDV);
        geneltoplam = sonfiyat+KDV;
        Console.WriteLine("Genel Toplam : "+geneltoplam);
        Console.WriteLine("*************************");
        

        Console.WriteLine("*powered by abidin*");


        Console.ReadKey();
    }
}