using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_UNICIV.Data;
using API_UNICIV.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_UNICIV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditoraController : Controller
    {
        private readonly BibliotecaContexto _bibliotecaContexto;

        public EditoraController(BibliotecaContexto bibliotecaContexto) {
            this._bibliotecaContexto = bibliotecaContexto;
        }

        [HttpGet]
        public async Task<IEnumerable<Editora>> get(){
            
            return await _bibliotecaContexto.editoras.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Editora>> getId(int id){
            var editora = await _bibliotecaContexto.editoras.FindAsync(id);

            if (editora == null) {
                return NotFound();
             }

            return editora;
        }

        [HttpPost]
        public async Task<ActionResult> add(Editora editora)
        {
            _bibliotecaContexto.editoras.Add(editora);

            await _bibliotecaContexto.SaveChangesAsync();

            return CreatedAtAction("Get", new { id= editora.id}, editora);
        }

    }
}
