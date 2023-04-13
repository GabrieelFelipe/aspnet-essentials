using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

//Trabalho para Amanhã:  Instalar Dependências
public class AppDbContext:DbContext{

//override (subrescrever)
//NãoTrair( ) - Contrato
//CompartilhamentoCarteira
//protected

protected override void OnConfiguring(DbContextOptionsBuilder builder){
 builder.UseSqlServer("Server=LA-F08-17;DataBase=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");

}
}



