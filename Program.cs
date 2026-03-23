// Validação de percentuais de uma eleição
// Criação e inicialização das variáveis
int votos, brancos, nulos = 0;

// Solicitação de dados do usuário
System.Console.WriteLine("*** Apuração de votos do município ***"); ;
System.Console.Write("Informe a quantidade de votos válidos: ");
votos = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Informe os votos do candidato A: ");
int candidatoA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite os votos do candidato B: ");
int candidatoB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos em branco: ");
brancos = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos nulos: ");
nulos = Convert.ToInt32(Console.ReadLine());

double percA = (double)candidatoA / votos * 100;
double percB = (double)candidatoB / votos *100;
double percNulo = (double)nulos / votos * 100;
double percBranco = (double)brancos / votos * 100;

if (percA >= 50)
{
    percA = percA + percNulo + percBranco;
}
else
{
    percB = percB + percNulo + percBranco;
}
// Divulgação das eleições
System.Console.WriteLine("Total de votos válidos: "+votos+ "\n"+
                         "Total de votos nulos: " +nulos+ "\n"+
                         "Total de votos em branco: "+brancos+ "\n"+
                         "Porcentagem candidato A: "+percA+"%"+ "\n"+
                         "Porcentagem candidato B: "+percB+"%");