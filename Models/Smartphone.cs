using System;

namespace DesafioPOO.Models
{
    // NÃO pode ser instanciada: serve como modelo
    public abstract class Smartphone
    {
        // Propriedades conforme diagrama
        public string Numero { get; set; }          // +
        private string Modelo { get; }              // -
        private string IMEI { get; }                // -
        private int Memoria { get; }                // -

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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

        // Cada marca instala de um jeito
        public abstract void InstalarAplicativo(string nome);

    }
}
