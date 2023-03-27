using bytebank_adm.Funcionarios;
using bytebank_adm.SistemaInterno;
using bytebank_adm.Utilitarios;


#region

// Funcionario pedro = new Funcionario("123456789", 2000);
// pedro.Nome = "Pedro Malazartes";
//
// Console.WriteLine("==============");
// Console.WriteLine("Nome: " + pedro.Nome);
// Console.WriteLine("Bonificação: " + pedro.GetBonificacao());
//     
// // ===================================================================== // 
//
// Diretor roberto = new Diretor("987654321");
// roberto.Nome = "Roberto Da Silva";
//
// Console.WriteLine("==============");
// Console.WriteLine("Nome: " + roberto.Nome);
// Console.WriteLine("Bonificação: " + roberto.GetBonificacao());
//
// // ===================================================================== // 
//
// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberto);
//
// Console.WriteLine("==============");
// Console.WriteLine("Total de Bonificações:" + gerenciador.TotalDeBonificacao);
// Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);
// Console.WriteLine("==============");
//
// // ===================================================================== //
//
// pedro.AumentarSalario();
// roberto.AumentarSalario();
//
// Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
// Console.WriteLine("Novo salário de Roberto: " + roberto.Salario);
// Console.WriteLine("==============");

#endregion

#region

// CalcularBonificacao();

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer felipe = new Designer("1345896");
    felipe.Nome = "Felipe Vieira";

    Diretor paula = new Diretor("1289474");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("1938709");
    igor.Nome = "Igor Gava";

    GerenteDeContas camilla = new GerenteDeContas("1294719508");
    camilla.Nome = "Camilla Tolotto";
    
    gerenciador.Registrar(camilla);
    gerenciador.Registrar(felipe);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor Ingrid = new Diretor("1234567");
    Ingrid.Nome = "Ingrid Novaes";
    Ingrid.Senha = "123";

    GerenteDeContas Ursula = new GerenteDeContas("28937555");
    Ursula.Nome = "Ursula Guedes";
    Ursula.Senha = "839245";

    sistema.Logar(Ingrid, "123");
    sistema.Logar(Ursula, "839245");
}   

#endregion

