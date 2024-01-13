using DesafioPOO.Models;

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1234", modelo: "XR", imei: "xxx-222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Classroom");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4321", modelo: "Tijolão", imei: "222-xxx", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Google Chrome");

Console.WriteLine("\n");