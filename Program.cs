using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nokia
            Smartphone nokia = new Nokia(numero: "81 99999-1111", modelo: "3310", imei: "000111222333444", memoria: 512);
            Console.WriteLine(nokia);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // iPhone
            Smartphone iphone = new Iphone(numero: "81 98888-2222", modelo: "14 Pro", imei: "555666777888999", memoria: 1024);
            Console.WriteLine(iphone);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("\nConcluído.");
        }
    }
}
