namespace bytebank_adm.Funcionarios
{
    // A classe funcionario virou uma classe abstrata, ou seja, uma classe que tem como função instanciar outras
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        private string Cpf { get; set; }

        // Para que seja possível visualizar Salario na classe Diretor é preciso passar o protected
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }
        
        // métodos abstratos 
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }
    }
}