Console.WriteLine($"| Corintihans X Palmeiras| ");


Console.WriteLine($"digite os gols do Corinthians: ");
int corinthiansGol = int.Parse (Console.ReadLine());

Console.WriteLine($"digite os gols do Palmeiras: ");
int palmeirasGol = int.Parse (Console.ReadLine());

if( corinthiansGol == palmeirasGol )

{


Console.WriteLine($"Empate!");


}

if(corinthiansGol > palmeirasGol)

{

Console.WriteLine($"Timao Vencedor! ");
Console.WriteLine($"Palmeiras nao tem Mundial kkkk ");

}



if(corinthiansGol < palmeirasGol)

{


Console.WriteLine($"Parmera ganhou !");



}