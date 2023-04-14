using AplicativoWeb.Models; //Chamada da camada modelo
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.EntityConfigs;

public class AppDbContext:DbContext{

    //DbContext representa o banco de dados.
    //DbSet representa a tabela.

    //Essa linha Seta (atribui) a classe curso a classe  Curso como a entidade no Banco de Daods (Context) EcolaDotNet
    public DbSet<Curso> cursos => Set<Curso>();//representa a tabela

        //override (subrescrever)
        //NãoTrair( ) - Contrato
        //CompartilhamentoCarteira
        //protected

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlServer("Server=LAB-F08-17;DataBase=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new CursoEntityConfig());
        }
        
    

}



