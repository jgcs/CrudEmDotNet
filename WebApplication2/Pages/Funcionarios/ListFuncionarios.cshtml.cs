using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Data;
using WebApplication2.Models.Dominio;

namespace WebApplication2.Pages.Funcionarios
{
    public class ListFuncionariosModel : PageModel
    {
        private readonly BancoDados bancoDados;

        public List<Models.Dominio.Funcionario> Funcionariosst { get; set; } //esta lista sera chamada no OnGet abaixo



        public ListFuncionariosModel(BancoDados bancoDados) //Construtor
        {
            this.bancoDados = bancoDados;
        }

        public void OnGet()  // essa var Funcionariosst é chamada na tela que lista os funcionarios
        {
             Funcionariosst = bancoDados.Funcionarios.ToList();
               

        }

    }
}
