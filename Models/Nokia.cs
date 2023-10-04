namespace DesafioPOO.Models
{
    // Feito: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {   
        public Nokia(string numero, string modelo, string imei, int memoria) : base( numero,  modelo,  imei,  memoria) {}
        // Feito: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Acessando a Google Play...\n Instalando {nomeApp}...\nInstalação concluida!");
        }
    }
}