using bytebank_adm.SistemaInterno;

namespace bytebank_adm.Funcionarios;

public class Diretor : Autenticavel
{
    public Diretor(string cpf) : base(cpf, 10000)
    {
    }
    public override double GetBonificacao()
    {
        // A palavra reservada "base" indica que estará pegando o elemento diretamente da classe Funcionario
        // return this.Salario + base.GetBonificacao();
        
        return this.Salario * 0.5;
    }

    public override void AumentarSalario()
    {
        this.Salario *= 1.15;
    }

    public override bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }
}