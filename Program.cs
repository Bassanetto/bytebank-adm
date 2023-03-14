using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;

// ===================================================================== // 

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine("==============");
Console.WriteLine(pedro.Nome);
Console.WriteLine("==============");
Console.WriteLine(pedro.GetBonificacao());
Console.WriteLine("==============");

// ===================================================================== // 

Diretor roberto = new Diretor();
roberto.Nome = "Roberto Da Silva";
roberto.Cpf = "987654321";
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