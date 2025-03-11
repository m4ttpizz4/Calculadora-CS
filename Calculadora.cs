//Calculadora CS v1.0:
using System;
class Calculadora{
  static void Main(){
    Console.WriteLine("Calculadora v1.0 by:m4ttpizz4 \nDigite o número da operação selecionada:\n");
    Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n");
    
    //Variável de escolha:
    int escolha = Convert.ToInt32(Console.ReadLine());
    
    //Operação de Soma:
    if(escolha == 1){
        Console.WriteLine("\nSelecione o primeiro número:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nSelecione o segundo número:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1+num2;
        Console.WriteLine("\nO valor da operação é {0}", resultado);
    }
    //Operação de Subtração:
    else if(escolha == 2){
        Console.WriteLine("\nSelecione o primeiro número:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nSelecione o segundo número:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1-num2;
        Console.WriteLine("\nO valor da operação é {0}", resultado);
    }
    //Operação de Multiplicação:
    else if(escolha == 3){
        Console.WriteLine("\nSelecione o primeiro número:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nSelecione o segundo número:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1*num2;
        Console.WriteLine("\nO valor da operação é {0}", resultado);
    }
    //Operação de Divisão:
    else if(escolha == 4){
        Console.WriteLine("\nSelecione o primeiro número:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nSelecione o segundo número:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1/num2;
        Console.WriteLine("\nO valor da operação é {0}", resultado);
    }
    //Nenhum número corresponde:
    else{
        Console.WriteLine("\nEsse número não corresponde a nenhuma operação.\n");
    }
  }
}
