using DesafioPOO.Models;


Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(
    numero: "11912345678",
    modelo: "Modelo 456",
    imei: "111",
    memoria: 64
);

nokia.Ligar();
nokia.InstalarAplicativo("Snake");


Console.WriteLine("\n"+"iPhone:");
Smartphone iphone = new Iphone(
    numero: "11987564321",
    modelo: "Modelo 16",
    imei: "222",
    memoria: 128
);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");