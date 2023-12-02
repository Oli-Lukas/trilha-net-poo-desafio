using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia...");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Smartphone iPhone...");
Smartphone iphone = new Iphone(numero: "54321", modelo: "Modelo 2", imei: "987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");