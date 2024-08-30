using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "27 9999-9999", modelo: "XWT-10", iMEI: "11111111111", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("XP Investimentos");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "27 8888-8888", modelo: "15", iMEI: "7777777777", memoria: 256);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Nubank");