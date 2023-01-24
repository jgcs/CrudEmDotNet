namespace WebApplication2.Models.Dominio
{

    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; } 
        public long Salario { get; set; }
        public DateTime DataDeAniversario { get; set; }

    }
}
