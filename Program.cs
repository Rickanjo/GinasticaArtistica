// See https://aka.ms/new-console-template for more information

Console.Write("Digite o nome do(a) ginasta: ");
string nome = Console.ReadLine()!;

Console.Write("Digite a nota do(a) ginasta: ");
double notaGinasta = double.Parse(Console.ReadLine()!);

Console.Write("Digite a nota de execução: ");
double notaExecucao = double.Parse(Console.ReadLine()!);


double notaFinal = notaGinasta + notaExecucao;
 
Console.WriteLine("A nota final de {0} é: {1}", nome, notaFinal);
