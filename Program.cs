using System;

namespace diziler;

class Program
{
    static void Main(string[] args)
    {
        // Dizi
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi", "Köpek", "Hamster", "Kuş"};

        int[] dizi;
        dizi = new int[5];

        // Dizilere değer atama
        renkler[0] = "Mavi";
        
        dizi[3] = 10;
        
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Döngülerde dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
        Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write(i+1 + ".sayı: ");
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (int sayi in sayiDizisi)
            toplam += sayi;
        
        Console.Write("Ortalama: " + toplam / diziUzunlugu);
    }
}
