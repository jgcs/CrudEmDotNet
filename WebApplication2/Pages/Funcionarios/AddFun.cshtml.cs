using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Data;
using WebApplication2.Models.Dominio;
using WebApplication2.Models.ViewModels;

namespace WebApplication2.Pages.Funcionarios
{
    public class AddFunModel : PageModel
    {

        private readonly BancoDados bancoDeDados;

        public AddFunModel( BancoDados bancoDeDados)
        {
            this.bancoDeDados = bancoDeDados;
        }



        [BindProperty] // isso serve para eu poder usar essa propriedade no razor pages
        public AddFuncionarioViewModel RequisicaoParaAdicionarFuncionario { get; set; }

        public void OnGet()
        {
           
        }


        public void OnPost()
        {
            // converter viewModel de funcionario para funcionario
            var novoFuncionario = new Funcionario
            {
                Nome = RequisicaoParaAdicionarFuncionario.Nome,
                Email = RequisicaoParaAdicionarFuncionario.Email,
                Salario = RequisicaoParaAdicionarFuncionario.Salario,
                DataDeAniversario = RequisicaoParaAdicionarFuncionario.DataDeAniversario
            };

            bancoDeDados.Funcionarios.Add(novoFuncionario);
            bancoDeDados.SaveChanges();
            ViewData["Message"] = "funcionario adicionado com sucesso";
          }
    }
}
