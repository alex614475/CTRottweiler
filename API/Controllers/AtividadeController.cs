using CTRottweiler.Database;
using CTRottweiler.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mapster;
using CTRottweiler.Entities;

namespace CTRottweiler.Controllers
{
    public class AtividadeController : ApiBaseController

    {


        [HttpGet] 

        public async Task<IActionResult> Get (
            [ FromServices] CTRottweilerDbContext context )

        {
            var atividade = await context.Atividades.ToListAsync();

            return Ok( atividade ); 
        }

        [HttpGet("{id:long}")]

        public async Task<IActionResult> GetById (
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context
            
            )

        {
            var atividade = await context.Atividades
                .Include(x => x.Instrutors)
                .FirstOrDefaultAsync(x => x.Id == id);
             
            if( atividade == null)
                return NotFound();

            return Ok(atividade);

        }


        [HttpPost]

        public async Task<IActionResult> Post(
            [FromBody] AtividadeDto dto,
            [FromServices] CTRottweilerDbContext context
            )
        
        {


             var atividade = dto.Adapt<Atividade>();
             context.Add(atividade);
             await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new {id= atividade}, atividade);

        }

        [HttpPut ("{id:long}")]

        public async Task<IActionResult> Put(
          [FromRoute] long id,
         [FromBody] AtividadeDto dto,
         [FromServices] CTRottweilerDbContext context
            )
        {

            var atividade = await context.Atividades.FirstOrDefaultAsync(x => x.Id == id);

            if (atividade == null)
                return NotFound();

            atividade = dto.Adapt(atividade);
            context.Update(atividade);
            await context.SaveChangesAsync();

            return Ok(atividade);   


        }

        [HttpDelete("{id:long}")]

        public async Task<IActionResult> Delete(
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context


            )
        
        {
          var atividade = await context.Atividades.FirstOrDefaultAsync(x => x.Id == id);

          if (atividade == null)
                return NotFound();


            context.Atividades.Remove(atividade);
            await context.SaveChangesAsync();
            return Ok();

        }
       
    }
}
