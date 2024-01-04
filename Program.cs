



using trilha_net_poo_desafio.Models;

Nokia nokia = new Nokia("83998061924" , "Nokia 5.4 Plus" , "123456789102356");
nokia.CadastrarMemoria(30);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Iphone iphone = new Iphone("84999925153" , "Iphone 14 pro max", "123456789156749");
iphone.CadastrarMemoria(54);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");