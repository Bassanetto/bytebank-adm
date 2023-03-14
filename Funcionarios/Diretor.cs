namespace bytebank_adm.Funcionarios;

public class Diretor
{
    public string Nome { get; set; }

    public string Cpf { get; set; }
    public double Salario { get; set; }

    public double GetBonificacao()
    {
        return this.Salario;
    }
}