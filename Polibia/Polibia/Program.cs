using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polibia
{
    class Program
    {
        static void Main(string[] args)
        { 

                var polybius = new PolybiusSquare();
                Console.Write("Введите текст: ");
                var message = Console.ReadLine().ToUpper();
                Console.Write("Введите ключ: ");
                var pass = Console.ReadLine().ToUpper();
                var cipherText = polybius.PolibiusEncrypt(message, pass);
                Console.WriteLine("Зашифрованный текст: {0}", cipherText);
                Console.WriteLine("Расшифрованный текст: {0}",
                polybius.PolybiusDecrypt(cipherText, pass));
                Console.ReadLine();
         
        }
    }
}
