namespace bytebank_adm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }

        private string Cpf { get; set; }

        // Para que seja possível visualizar Salario na classe Diretor é preciso passar o protected
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}