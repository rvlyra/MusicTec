using System.ComponentModel.DataAnnotations;
namespace apiCourses.Models
{
  public class Category
  {
    // Key será a chave do Id  
    [Key]
    public int Id { get; set; }

    // Validações do campo de título
    [Required(ErrorMessage = "Esse campo é obrigatório.")]
    [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
    [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
    public string Title { get; set; }
  }
}