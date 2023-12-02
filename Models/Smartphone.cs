namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public string Numero { get; set; }

        public Smartphone(
            string modelo,
            string imei,
            int memoria,
            string numero
        ) {
            Modelo  = modelo;
            IMEI    = imei;
            Memoria = memoria;
            Numero  = numero;
        }

        public void Ligar()
        { Console.WriteLine("Ligando..."); }

        public void ReceberLigacao()
        { Console.WriteLine("Recebendo ligação..."); }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}