using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654", modelo: "Modelo #1", imei: "112123123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("PrimeVideo");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "876562", modelo: "Modelo #2", imei: "232233232323", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");