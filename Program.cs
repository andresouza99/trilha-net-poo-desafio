using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("-Nokia-");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "1111", memoria: 64);
Console.WriteLine("Número: " + nokia.Numero);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("-iPhone-");
Smartphone iphone = new Iphone(numero: "456", modelo: "Modelo 2", imei: "2222", memoria: 128);
Console.WriteLine("Número: " + iphone.Numero);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

