using bytebank_adm.Funcionarios;

namespace bytebank_adm.Utilitarios;

public class GerenciadorDeBonificacao
{
    public double TotalDeBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        this.TotalDeBonificacao += funcionario.GetBonificacao();
    }
    public void Registrar(Diretor diretor)
    {
        this.TotalDeBonificacao += diretor.GetBonificacao();
    }
}