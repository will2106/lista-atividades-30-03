

/*Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
Sendo    que:    
− Triângulo    Equilátero:    possui    os    3    lados    iguais.
− Triângulo    Isóscele:    possui    2    lados    iguais.
− Triângulo    Escaleno:    possui    3    lados    diferentes.



/*
Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
Sendo    que:    
− Triângulo    Equilátero:    possui    os    3    lados    iguais.
− Triângulo    Isóscele:    possui    2    lados    iguais.
− Triângulo    Escaleno:    possui    3    lados    diferentes.


*/



Console.WriteLine($"gigite o lado 1: ");
string ladoUm = Console.ReadLine();


Console.WriteLine($"gigite o lado 2: ");
string ladoDois =  Console.ReadLine();

Console.WriteLine($"gigite o lado 3: ");
string ladoTres =  Console.ReadLine();

if (ladoUm == ladoDois && ladoDois == ladoTres ) 

{

Console.WriteLine($"Triangulo equilatero! ");

}


 if (ladoUm == ladoDois && ladoTres != ladoDois )

{

Console.WriteLine($"Triangulo Isoceles!");

}

if (ladoUm!=ladoDois && ladoDois!=ladoTres)

{


Console.WriteLine($"Triangulo Escaleno!");




}