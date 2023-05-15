using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };

        InsertionSort(dizi); // Dizi Binary Search yöntemi ile arama yapılabilmesi için Insertion Sort fonksiyonu ile sıralanıyor

        Console.Write($"Dizinin elemanları: ");
        Array.ForEach(dizi, item => Console.Write($"{item} ")); // Lambda "=>" yöntemi ile ForEach döngüsü ile sıralanmış dizi elemanlarını ekrana yazma
        Console.WriteLine();

        Console.Write("Aranacak elemanı girin: ");
        int arananEleman = int.Parse(Console.ReadLine());

        bool sonuc = BinarySearch(dizi, arananEleman); // Aranan elemanın olup olmadığının BinarySearch fonksiyonu ile kontrolü 

        if (sonuc)
            Console.WriteLine("Aradığınız eleman bulundu.");
        else
            Console.WriteLine("Aradığınız eleman bulunamadı.");

        Console.ReadLine();
    }

    static bool BinarySearch(int[] dizi, int target) // Binary Search yöntemi ile aranan elemanı bulan fonksiyon
    {
        int sol = 0;
        int sag = dizi.Length - 1;

        while (sol <= sag)  
        {
            int orta = (sol + sag) / 2;

            if (dizi[orta] == target)
                return true;

            if (dizi[orta] < target)
                sol = orta + 1;
            else
                sag = orta - 1;
        }

        return false;
    }
    static void InsertionSort(int[] dizi) // Parametre olarak gelen diziyi Insertion Sort algoritması ile sıralayan fonksiyon
    {
        int n = dizi.Length;

        for (int i = 1; i < n; i++)
        {
            int key = dizi[i];
            int j = i - 1;

            while (j >= 0 && dizi[j] > key)
            {
                dizi[j + 1] = dizi[j];
                j = j - 1;
            }

            dizi[j + 1] = key;
        }
    }
}
