// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var o = new Octopus();    // Criação de um objeto do tipo Octopus. New está criando uma instância

Console.WriteLine("idade: "+ o.Age + "\n nome: " + o.name + "\n nome2: " + o.name2); // 10
Console.WriteLine("\n Segundo Comando:" + o.codigo + "\nLegs =" + o.Legs);  // Jack 
Console.WriteLine("\n Terceiro Comando:" + Test.Message + "\n twoPI= " + Test.twoPI + "\n");  
Console.WriteLine($"Quarto Comando = {Foo1(10) == Foo2(10)}");    // True
int Foo1(int x) { return x * 2; }
int Foo2(int x) => x * 2;           


WriteCubes();

void WriteCubes()
{ 
  Console.WriteLine("\n Quinto Comando:");  
  Console.WriteLine($"3 ao cubo = {Cube(3)}");    // 27
  Console.WriteLine($"4 ao cubo = {Cube(4)}");    // 64
  Console.WriteLine($"5 ao cubo = {Cube(5)}");    // 125

  int Cube(int value) => value * value * value;   // Método local
}


class Octopus
{
  public string name = "Aline";            // Atributo do tipo string, sem valor
  public int Age = 10;    // Atributo do tipo int, com valor

  public string name2 = "Levi";


  public readonly string codigo = "Rodando segunda linha codigos";
  public readonly int Legs = 8;
  

}

public class Test
{
  public const string Message = " Rodando terceira linha codigo";
  public const double twoPI  = 2 * System.Math.PI;   // Computação executada em tempo de compilação. Fazendo 2 * valor de PI
}


// Atividade 2 - Controle de Versão

// V1.0
// V2.0
// V3.0
// V4.0
// V3.1
// V3.2
// V2.1
// V2.2
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



