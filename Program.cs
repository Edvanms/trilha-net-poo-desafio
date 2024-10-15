using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("(11)123456789", "Nokia G11 Plus", "123456789", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Roblox");
Console.WriteLine($"O número do Smartphone Nokia é: {nokia.Numero}");


Console.WriteLine("");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("(11)987654321", "iPhone 15", "987654321", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine($"O número do Smartphone iPhone é: {iphone.Numero}");

