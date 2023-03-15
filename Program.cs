using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;

// ===================================================================== // 

Funcionario pedro = new Funcionario("123456789");
pedro.Nome = "Pedro Malazartes";
pedro.Salario = 2000;

Console.WriteLine("==============");
Console.WriteLine(pedro.Nome);
Console.WriteLine("==============");
Console.WriteLine(pedro.GetBonificacao());

// ===================================================================== // 

Diretor roberto = new Diretor("987654321");
roberto.Nome = "Roberto Da Silva";
roberto.Salario = 15000;

Console.WriteLine("==============");
Console.WriteLine(roberto.Nome);
Console.WriteLine("==============");
Console.WriteLine(roberto.GetBonificacao());

// ===================================================================== // 

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberto);

Console.WriteLine("==============");
Console.WriteLine("Total de Bonificações:" + gerenciador.TotalDeBonificacao);
Console.WriteLine("==============");
Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);
Console.WriteLine("==============");
