/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 29-03-2023
 */

namespace Aula_do_Dia_29_03_2023
{
    class Program
    {

        static void Main(string[] args)
        {
            // 3. Variáveis
            string nomeFuncionario;
            double salarioAtual;
            double salarioReajustado;
            double valorReajuste = 8.75;

            // 4. Entrada de Dados

            Console.WriteLine("Esse algoritmo calcula o reajuste de salários dos funcionários");
            Console.WriteLine("Digite o nome do funcionário");
           
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Digite o salário atual");
            salarioAtual = double.Parse(Console.ReadLine());

            // 5. Processamento
            salarioReajustado = salarioAtual + (salarioAtual * valorReajuste / 100);
            /*  OU
            salarioReajustado = salarioAtual += salarioAtual * 0.0875;
                OU          
            salarioReajustado = salarioAtual + (salarioAtual * 0.0875);
                OU
            salarioReajustado = (salarioAtual * 1.0875);
            OU 
            salarioReajustado += salarioAtual * 1.0875;
            */

            Console.WriteLine("O salário do funcionário: " + nomeFuncionario + 
                "depois do reajuste é: " + salarioReajustado);
            Console.ReadKey();
        }
    }
}
