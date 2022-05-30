using Microsoft.EntityFrameworkCore;
using apiCourses.Models;

namespace apiCourses.Data
{
  // Não há string de conexão, pois estamos trabalhando com banco em memória.

  // DataContext herda propriedades e atributos de DbContext
  public class DataContext : DbContext
  {
    // Connetion string
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // Setando as tabelas que desejamos usar no banco de dados. O banco será criado com o comando 
    public DbSet<Course> Courses { get; set; }
    public DbSet<Category> Categories { get; set; }

  }

}
