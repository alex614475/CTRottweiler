using CTRottweiler.Database;
using CTRottweiler.Dtos;
using CTRottweiler.Entities;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTRottweiler.Controllers
{

    public class AlunoController : ApiBaseController
    {
        [HttpGet]

        public async Task<IActionResult> Get([FromServices] CTRottweilerDbContext context)
        {
            var alunos = await context.Alunos.ToListAsync();
            return Ok(alunos);
        }

        [HttpGet ("{id:long}")]

        public async Task<IActionResult> GetById(
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context)
        {
            var aluno = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);

            if (aluno == null)
                return NotFound();
            return Ok(aluno);
        }


        [HttpPost]

        public async Task<IActionResult> Post(
       [FromBody] AlunoDto dto,
       [FromServices] CTRottweilerDbContext context)
        {

            var aluno = dto.Adapt<Aluno>();
             context.Add(aluno);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }




        [HttpPut("{id:long}")]

        public async Task<IActionResult> Put(
            [FromRoute] long id,
            [FromBody] AlunoDto dto,
            [FromServices] CTRottweilerDbContext context)
        {

            var aluno = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);

            if (aluno == null)
                return NotFound();

            aluno = dto.Adapt(aluno);
           context.Update(aluno);
            await context.SaveChangesAsync();
            return Ok(aluno);
        }



        [HttpDelete("{id:long}")]

        public async Task<IActionResult> Delete (
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context
            )

        {
            var aluno = await context.Alunos.FirstOrDefaultAsync(x => x.Id == id);

            if (aluno == null)
                return NotFound();

            context.Alunos.Remove(aluno);
            await context.SaveChangesAsync();

            return Ok(); 

        }
    }

}
