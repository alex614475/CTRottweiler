using CTRottweiler.Database;
using CTRottweiler.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mapster;
using CTRottweiler.Entities;

namespace CTRottweiler.Controllers
{
    public class InstrutorController : ApiBaseController
    {

        [HttpGet]

        public async Task<IActionResult> Get(
            [FromServices] CTRottweilerDbContext context  )
        {
            var instrutor = await context.Instrutors.ToListAsync();
            return Ok( instrutor );


        }

        [HttpGet ("{id:long}") ]

        public async Task<IActionResult> GetById(
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context)
        {

            var instrutor = await context.Instrutors.FirstOrDefaultAsync( x => x.Id == id );    


            if (instrutor == null)
                return NotFound();

            return Ok(instrutor);


        }

        [HttpPost] 
        
        public async Task<IActionResult> Post
            (
            [FromBody] InstrutorDto dto,
            [FromServices] CTRottweilerDbContext context
            )
        {
            var instrutor = dto.Adapt<Instrutor>();
            context.Add(instrutor);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = instrutor.Id }, instrutor);

             
        }
        
        [HttpPut("{id:long}")]

        public async Task<IActionResult>Put(

            [FromRoute] long id,
            [FromBody] InstrutorDto dto,
            [FromServices] CTRottweilerDbContext context )
        {
            var instrutor = await context.Instrutors.FirstOrDefaultAsync(x => x.Id ==id);

            if (instrutor == null)
                return NotFound();

            instrutor = dto.Adapt(instrutor);   
            context.Update(instrutor);
            await context.SaveChangesAsync();

            return Ok(instrutor);

           


        }

        [HttpDelete("{id:long}")]

        public async Task<IActionResult>Delete(
            [FromRoute] long id,
            [FromServices] CTRottweilerDbContext context

            )
        {
            var instrutor = await context.Instrutors.FirstOrDefaultAsync(x => x.Id == id);

            if (instrutor == null)
                return NotFound();

            context.Instrutors.Remove(instrutor);
            await context.SaveChangesAsync();

            return Ok();


        }


    }
}
