namespace bytebank_adm.Funcionarios;

public class Diretor : Funcionario
{
    public override double GetBonificacao()
    {
        // A palavra reservada "base" indica que estará pegando o elemento diretamente da classe Funcionario
        return this.Salario + base.GetBonificacao();
    }

    public Diretor(string cpf, double salario) : base(cpf, salario)
    {
        
    }
    
    public override void AumentarSalario()
    {
        this.Salario *= 1.15;
    }
}