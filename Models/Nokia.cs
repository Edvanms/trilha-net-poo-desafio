namespace DesafioPOO.Models
{    
    public class Nokia : Smartphone
    {
       public Nokia(string numero, string modeloSmartPhone, string imeiSmartPhone, int memoriaSmartPhone) : base(numero, modeloSmartPhone, imeiSmartPhone, memoriaSmartPhone)
       {

       }
       public override void InstalarAplicativo(string nomeApp) {
        Console.WriteLine($"Instalando {nomeApp} no Nokia...");
       }
    
    }
}