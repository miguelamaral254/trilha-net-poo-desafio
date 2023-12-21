using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string marca, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void LigarTelefone()
        {
            Console.WriteLine($"{Marca} modelo: {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
