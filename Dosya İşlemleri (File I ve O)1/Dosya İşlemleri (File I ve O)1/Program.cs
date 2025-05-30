using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Dosya_İşlemleri__File_I_ve_O_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "C:\\Users\\mitha\\source\\repos\\Dosya İşlemleri (File I ve O)1\\Dosya İşlemleri (File I ve O)1\\ornek1.txt";

            // Dosyaya yazma
            string[] bilgiler = { "Merhaba", "C# ile dosya işlemleri", "StreamWriter örneği" };
            File.WriteAllLines(dosyaYolu, bilgiler);
            Console.WriteLine("Dosya başarıyla yazıldı.");

            // Dosyadan okuma
            string[] okunanSatirlar = File.ReadAllLines(dosyaYolu);
            Console.WriteLine("\nDosya içeriği:");
            foreach (var satir in okunanSatirlar)
            {
                Console.WriteLine(satir);
            }
        }
    }
}
