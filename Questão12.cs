using System;
class HelloWorld {
   static void entrada(float[] vetora, float[] vetorb){
        int i;
        float soma = 0;
        float[] vetorc  = new float[8];
        for(i = 0; i<8; i++){
            Console.WriteLine($"Escreva o elemento {i} do primeiro vetor");
            vetora[i] = float.Parse(Console.ReadLine());
            Console.WriteLine($"Escreva o elemento {i} do segundo vetor");
            vetorb[i] = float.Parse(Console.ReadLine());
            soma = vetora[i] + vetorb[i];        
            vetorc[i] = soma;
        }
        Console.WriteLine($"Os elementos do terceiro vetor são:");
        for(i = 0; i<8; i++){
            Console.Write("{0}\t", vetorc[i]);
    }     
  }

  static void Main() {
    float[] vetora  = new float[8];
    float[] vetorb  = new float[8];
    
    entrada(vetorb, vetora);
}
}
