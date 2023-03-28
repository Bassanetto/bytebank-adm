using bytebank_adm.Funcionarios;
using bytebank_adm.Parceria;

namespace bytebank_adm.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(IAutenticavel autenticavel, string senha)
    {
        bool usuarioAutenticado = autenticavel.Autenticar(senha);
        if (usuarioAutenticado)
        {
            Console.WriteLine("Boas Vindas ao nosso sistema!");
            return true;
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}