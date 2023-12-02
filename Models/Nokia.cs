namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(
            string modelo,
            string imei,
            int memoria,
            string numero
        ) : base(modelo, imei, memoria, numero) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia!!!");
        }
    }
}