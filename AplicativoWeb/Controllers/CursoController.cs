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
        ViewData["desc"] = c1.Descricao;
        ViewData["titInt"]  = c1.TituloInterno;
        ViewData["titMark"] = c1.TituloMarketing;
        return View();
    }
}