using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public abstract class Autenticavel : Funcionario
{
    public string Senha { get; set; }

    public abstract bool Autenticar(string senha);
    public Autenticavel(string cpf, double salario) : base(cpf, salario)
    {
    }
}