using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("44441123", "G11 Plus", "2222222222", 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tetris");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("89897327", "Iphone 15", "11223344", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surfers");