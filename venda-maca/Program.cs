/*)
As    
maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
 e R$ 0,25 se forem compradas pelo menos doze. 
Escreva um programa que leia o número de maçãs compradas, 
calcule e escreva o valor    total    da compra.*/


//entrada
Console.WriteLine($"olá seja bem vindo,digite a quantidade de maças que voce deseja comprar:");

int quantidadeMaca=int.Parse(Console.ReadLine());

float Precomaca;



if (quantidadeMaca==12)
{
    
    Precomaca=0.25f;


}

else
{
    
 Precomaca=0.30f;

}


float valorTotal= quantidadeMaca * Precomaca;
Console.WriteLine($"O valor total da compra é {valorTotal} reais!");
