///<sumary>
///Possuir as informações da quantidade de convidados do noivo e da noiva,
///verificar a quantidade de pessoas presentes de cada lado,
///retornar quantos penetras há na festa
///SE convidadosPresentesNoivo > ou < convidadosPresentesNoiva,
///</sumary>
using System;
using System.Globalization;
namespace Ex1Lista1
{
class ListaConvidadosCasamento
{
static void Main()
{
//variáveis a serem usadas
int convidadosNoivo = 0;
int convidadosNoiva = 0;
int convidadosPresentesNoivo = 0;
int convidadosPresentesNoiva = 0;
string op;
int qt;
//muda a localização, no caso foi feito para aceitar caracteres BR
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
Console.WriteLine("Total de Convite do Noivo? ");
convidadosNoivo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total de Convite da Noiva? ");
convidadosNoiva = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Controle de Convidados Presentes ao casamento. ");
do
{
Console.WriteLine("\n1. Adicionar convidado do Noivo; \n2. Adicionar convidado da
Noiva; \n3. Sair; ");
op = Console.ReadLine();
switch (op)
{
case "1":
Console.WriteLine("Favor, digite a quantidade de convidados: ");
qt = Convert.ToInt32(Console.ReadLine());

convidadosPresentesNoivo = convidadosPresentesNoivo + qt;
break;
case "2":
Console.WriteLine("Favor, digite a quantidade de convidados: ");
qt = Convert.ToInt32(Console.ReadLine());
convidadosPresentesNoiva = convidadosPresentesNoiva + qt;
break;
case "3":
break;
}//fim switch
} while (op !="3");

if (op == "3")
{
if (convidadosPresentesNoiva > convidadosPresentesNoivo)
{
Console.WriteLine("O número de convidados presentes da Noiva é maior.");
}
else if (convidadosPresentesNoivo > convidadosPresentesNoiva)
{
Console.WriteLine("O número de convidados presentes do Noivo é maior.");
}
}

if (convidadosPresentesNoiva > convidadosNoiva && convidadosPresentesNoivo >
convidadosNoivo)
{
Console.WriteLine("Há penetras na festa! O número de convidados não é compatível
com a lista.");
}
else
{
Console.WriteLine("Não há penetras na festa. ");
}
}//fim main
}//fim classe ListaConvidadosCasamento
}//fim Ex1Lista1
