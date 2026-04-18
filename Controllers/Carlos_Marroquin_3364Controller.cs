using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class Carlos_Marroquin_3364Controller : ControllerBase
{
    private readonly AppDbContext _context;

    public Carlos_Marroquin_3364Controller(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Carlos_Marroquin_3364
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carlos_Marroquin_3364>>> GetCursos()
    {
        return await _context.Carlos_Marroquin_3364.ToListAsync();
    }

    // GET: api/Carlos_Marroquin_3364/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Carlos_Marroquin_3364>> GetCurso(int id)
    {
        var curso = await _context.Carlos_Marroquin_3364.FindAsync(id);

        if (curso == null)
            return NotFound();

        return curso;
    }

    // POST: api/Carlos_Marroquin_3364
    [HttpPost]
    public async Task<ActionResult<Carlos_Marroquin_3364>> PostCurso(Carlos_Marroquin_3364 curso)
    {
        _context.Carlos_Marroquin_3364.Add(curso);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCurso), new { id = curso.IdCurso }, curso);
    }

    // PUT: api/Carlos_Marroquin_3364/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCurso(int id, Carlos_Marroquin_3364 curso)
    {
        if (id != curso.IdCurso)
            return BadRequest();

        _context.Entry(curso).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/Carlos_Marroquin_3364/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCurso(int id)
    {
        var curso = await _context.Carlos_Marroquin_3364.FindAsync(id);

        if (curso == null)
            return NotFound();

        _context.Carlos_Marroquin_3364.Remove(curso);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}