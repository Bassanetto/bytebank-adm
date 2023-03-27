using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(Autenticavel autenticavel, string senha)
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