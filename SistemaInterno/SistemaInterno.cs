using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(Diretor diretor, string senha)
    {
        bool usuarioAutenticado = diretor.Autenticar(senha);
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
    
    public bool Logar(GerenteDeContas gerente, string senha)
    {
        bool usuarioAutenticado = gerente.Autenticar(senha);
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