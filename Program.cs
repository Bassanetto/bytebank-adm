using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;

// ===================================================================== // 

Funcionario pedro = new Funcionario("123456789", 2000);
pedro.Nome = "Pedro Malazartes";

Console.WriteLine("==============");
Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("Bonificação: " + pedro.GetBonificacao());

// ===================================================================== // 

Diretor roberto = new Diretor("987654321", 15000);
roberto.Nome = "Roberto Da Silva";

Console.WriteLine("==============");
Console.WriteLine("Nome: " + roberto.Nome);
Console.WriteLine("Bonificação: " + roberto.GetBonificacao());

// ===================================================================== // 

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberto);

Console.WriteLine("==============");
Console.WriteLine("Total de Bonificações:" + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);
Console.WriteLine("==============");

// ===================================================================== //

pedro.AumentarSalario();
roberto.AumentarSalario();

Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
Console.WriteLine("Novo salário de Roberto: " + roberto.Salario);
Console.WriteLine("==============");
