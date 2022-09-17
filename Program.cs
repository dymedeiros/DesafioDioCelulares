using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("999999","Lumia","1111",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone");
Iphone iphone = new Iphone("7777","apple","222",128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");
