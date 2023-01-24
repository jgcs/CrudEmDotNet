using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Dominio;

namespace WebApplication2.Data
{
    public class BancoDados : DbContext
    {

        public BancoDados(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }






    }
}
