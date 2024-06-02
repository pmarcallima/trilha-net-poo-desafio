using DesafioPOO.Models;

Nokia n = new Nokia("999999999", "Nokia 3200", "223", 256);
Iphone p = new Iphone("899999999", "Iphone 5s", "22344", 512);

Console.WriteLine("Smartphone Nokia");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Facebook");

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone");
p.Ligar();
p.ReceberLigacao();
p.InstalarAplicativo("Spotify");
