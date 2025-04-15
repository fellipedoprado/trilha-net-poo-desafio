namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementação das propriedades faltantes de acordo com o diagrama
        private string Modelo { get; }
        private string IMEI { get; }
        private string Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            // Passando os parâmetros do construtor para as propriedades
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

        public abstract void InstalarAplicativo(string nomeApp);
    }
}