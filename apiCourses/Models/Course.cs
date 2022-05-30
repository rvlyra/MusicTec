using System.ComponentModel.DataAnnotations;
namespace apiCourses.Models
{
  public class Course
  {
    [Key]
    public int Id { get; set; }

    // Validações do campo de título
    [Required(ErrorMessage = "Esse campo é obrigatório.")]
    [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
    [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
    public string Title { get; set; }

    [MaxLength(1024, ErrorMessage = "Esse campo deve conter, no máximo, 1024 caracteres")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Esse campo é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que 0 (zero).")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Esse campo é obrigatório.")]
    [MaxLength(40, ErrorMessage = "Esse campo deve conter entre 3 e 40 caracteres")]
    [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
    public string Level { get; set; }

    [Required(ErrorMessage = "Esse campo é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida.")]

    // Propriedade que referencia o id da categoria no banco.
    public int CategoryId { get; set; }
    // Camada de propriedade de navegação, usada para acessar informações da "categoria", como título.
    public Category Category { get; set; }


  }
}