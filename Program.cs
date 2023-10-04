using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone11 = new Iphone(numero: "99995425", modelo: "iphone11", imei: "111111", memoria: 128);
iphone11.Ligar();
iphone11.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokiaC01Plus = new Nokia(numero: "99996425", modelo: "nokiaC01Plus", imei: "222222", memoria: 128);
nokiaC01Plus.Ligar();
nokiaC01Plus.InstalarAplicativo("Telegram");

