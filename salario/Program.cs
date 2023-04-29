//entradas
Console.WriteLine($"digite seu salario :");
int salario= int.Parse (Console.ReadLine());

Console.WriteLine($"digite seus gastos :");
int gastosMes= int.Parse (Console.ReadLine());

int orcamento= salario-gastosMes;

if( salario > gastosMes)
{

Console.WriteLine($"Gastos dentro do Orcamento ! :)");



}

else{

Console.WriteLine($"Orcamento estourado ! :(");


}


