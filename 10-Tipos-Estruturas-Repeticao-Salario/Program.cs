// Faça um algoritmo que calcula e exiba o salário reajustado de 10 funcionários de acordo com
// a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

using _10_Tipos_Estruturas_Repeticao_Salario;

double novoSalario = 0;

List<double> salarios = new List<double>();


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o sálario:");
    double salario = Convert.ToDouble(Console.ReadLine());

    novoSalario = Salario.CalculaReajuste(salario);

    Console.WriteLine("Salário reajustado: " + novoSalario);
}

