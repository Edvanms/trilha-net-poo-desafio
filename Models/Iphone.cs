namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloSmartPhone, string imeiSmartPhone, int memoriaSmartPhone) : base(numero, modeloSmartPhone, imeiSmartPhone, memoriaSmartPhone)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}