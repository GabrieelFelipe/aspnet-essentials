
//agrupar classes
namespace GerenciaTarefa.Models;
//Conjunto de Objetos
public class Tarefa{

    //Classe é um conjunto de objetos
    //Propriedades Automaticas
    public int id { get; set; } // numero inteiro
    public string? Cabecalho { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; } //texto

    public bool TaCompleta { get; set; } // Boleana sim ou não
    //Funcionalidades

}