namespace bytebank_adm.Funcionarios;

public class Diretor : Funcionario
{
    public override double GetBonificacao()
    {
        // A palavra reservada "base" indica que estará pegando o elemento diretamente da classe Funcionario
        return this.Salario + base.GetBonificacao();
    }
}