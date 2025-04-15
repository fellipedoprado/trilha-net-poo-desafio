using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
// Instanciando um objeto da classe Iphone
Iphone iphone = new Iphone("123456789", "iPhone 12", "123456789012345", "128GB");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Nokia:");
// Instanciando um objeto da classe Nokia
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", "16MB");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nTeste concluído com sucesso!");