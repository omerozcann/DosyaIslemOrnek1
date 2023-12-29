using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan Ders adı, sınav türü ve sınav notunu 
            //dosyaya kaydedecek programı yazınız.
            String dersadi, sinavturu, sinavnotu;
            Console.WriteLine("Ders Adı:");
            dersadi= Console.ReadLine();
            Console.WriteLine("Sınav Türü:");
            sinavturu = Console.ReadLine();
            Console.WriteLine("Sınav Notu:");
            sinavnotu = Console.ReadLine();
            File.AppendAllText("d:\\notlarim.txt", dersadi + "-" + sinavturu + "-" + sinavnotu+"\n");
            //satır sonundaki \n bir alt satıra inmek için kullanılır.
        }
    }
}
