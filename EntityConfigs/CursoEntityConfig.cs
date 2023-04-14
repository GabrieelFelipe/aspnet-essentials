using AplicativoWeb.Models;  //Camada models
using Microsoft.EntityFrameworkCore; //EF Framework
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Fluent API
namespace AplicativoWeb.EntityConfigs; //Novo namespace


public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{ //Inicio
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
         //Chaves são Unicas - Unversais - Imutáveis

         builder.ToTable("Curso"); //Nome da tabela: Curso
    
         //Lambda --> forma reduzida de uma public void

         //Id
         builder.HasKey(c=>c.Id); //Id - Chave primária

         //Título Marketing  
         builder.Property(c=>c.TituloMarketing)
              .HasColumnType("nvarchar(80)")
              .IsRequired();

         //TítuloInterno 
         builder.Property(c=>c.TituloInterno)
              .HasColumnType("nvarchar(80)")
              .IsRequired();

         //Descrição 
         builder.Property(c=>c.Descricao)
              .HasColumnType("text")
              .IsRequired();


    }
} //Fim