using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public interface IAutenticavel 
{
    public string Senha { get; set; }

    public abstract bool Autenticar(string senha);
}