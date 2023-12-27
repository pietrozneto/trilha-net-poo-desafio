using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero : "135791357", modelo: "Tijolo", imei : "11222", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash of clans");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero : "2135791357", modelo: "35promax", imei : "4444444", memoria: 2048);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clahs royale");