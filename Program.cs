using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 8", imei: "111111", memoria: 1500);

        Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "222222", memoria: 2000);

        nokia.LigarTelefone();
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();
        iphone.LigarTelefone();
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
