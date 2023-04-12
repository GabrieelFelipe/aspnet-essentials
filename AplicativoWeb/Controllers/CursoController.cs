using AplicativoWeb.Models; //camada model
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers; //Definição
//Criamos a classe Controller

public class CursoController:Controller{
     public IActionResult Index(){
        //set
        Curso c1 = new Curso();
        c1.Descricao = "Primeiros passos no ASP.NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie Aplicativo Incríveis";
        
        //get
        ViewData["curso"] = c1;//passando
               return View();
    }

        public IActionResult Create(){
                ViewData["título"] = "Cadastro de Cursos";
                ViewBag.DataHora = DateTime.Now;
                return View();
    }
}