// Validação de percentuais de uma eleição
// Criação e inicialização das variáveis
int votos, brancos, nulos = 0;

// Solicitação de dados do usuário
System.Console.WriteLine("*** Apuração de votos do município ***"); ;
System.Console.Write("Informe a quantidade de votos válidos: ");
votos = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos em branco: ");
brancos = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos nulos: ");
nulos = Convert.ToInt32(Console.ReadLine());

// Condição de existência de triângulo
// A soma de dois lados quaisquer deve ser sempre maior que o terceiro lado
System.Console.WriteLine($"Total de {votos} votos válidos, {brancos} votos em branco e {nulos} votos nulos");