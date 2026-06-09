double n1, n2, media; 
Console.Write("Nota 1: "); 
n1 = double.Parse(Console.ReadLine()); 
Console.Write("Nota 2: "); 
n2 = double.Parse(Console.ReadLine()); 
media = (n1 + n2) / 2; 
if (media >= 7) 
{ 
    Console.WriteLine("Aprovado"); 
    } 
    else 
    {
         Console.WriteLine("Reprovado"); 
         }