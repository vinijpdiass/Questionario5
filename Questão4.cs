using System;
class HelloWorld {
  static int fatorial(int numero){
    int produto = numero;
    for (int i = numero - 1; i >= 1; i--){
        
        produto = produto * i;
        
    }
    return produto;
  }
  static void Main() {
    int numero, i;
    int resultado = 0;  
    i = 0;
    while (i <= 15){
        numero = i;
        resultado = fatorial(numero);
        Console.WriteLine($"o fatorial de {i} é {resultado}");        
        i++;
        
    }
  }
}
