int numero, contador; 
Console.Write("Digite um número: ");
 numero = int.Parse(Console.ReadLine()); 
 contador = 1; while (contador <= 10) 
 { 
    Console.WriteLine(numero * contador);
    contador++;
}