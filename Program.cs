using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia n1 = new Nokia(numero:"13996285971", modelo:"Nokia e30+", imei:"252512525", memoria: 8);
n1.InstalarAplicativo("Facebook");

Console.WriteLine("==========================================");

Iphone iphone= new Iphone(numero:"13996378295", modelo:"Iphone15", imei: "987654321", memoria: 12);
iphone.InstalarAplicativo("Linkedin");