using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiCourses.Data;
using apiCourses.Models;

namespace apiCourses.Controllers
{
  [ApiController]
  [Route("v1/courses")]
  public class CourseController : ControllerBase
  {
    /** Método inicial: HttpGet */

    // Todos os cursos

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Course>>> Get([FromServices] DataContext context)
    {
      var courses = await context.Courses.Include(x => x.Category).ToListAsync();
      return courses;
    }

    // Cada curso
    [HttpGet]
    [Route("{id:int}")]  // int insere uma restrição de rota. Aceita apenas o tipo inteiro.
    public async Task<ActionResult<Course>> GetById([FromServices] DataContext context, int id)
    {                                                // A função garante que se for encontrado mais de um curso, será retornado o primeiro curso.
      var course = await context.Courses.Include(x => x.Category)
            .AsNoTracking()    // Para impedir que o ef crie proxy dos objetos. 
            .FirstOrDefaultAsync(x => x.Id == id);
      return course;
    }

    [HttpGet]
    [Route("categories/{id:int}")]  // int insere uma restrição de rota. Aceita apenas o tipo inteiro.
    public async Task<ActionResult<List<Course>>> GetByCategory([FromServices] DataContext context, int id)
    {                                                // A função garante que se for encontrado mais de um curso, será retornado o primeiro curso.
      var courses = await context.Courses
            .Include(x => x.Category)
            .AsNoTracking()
            .Where(x => x.Id == id)
            .ToListAsync(); // ToList deve vir ao final da requisição para evitar overdump.
      return courses;
    }
  }


}