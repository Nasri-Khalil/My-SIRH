using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborateursController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;



        public CollaborateursController(ICollaborateurService collaborateurService)
        {
            this._collaborateurService = collaborateurService;
        }



        // GET: api/Collaborateur
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetCollaborateurs()
        {
            var result = await _collaborateurService.GetCollaborateurs();
            return Ok(result);
        }



        // POST: api/Collaborateurs
        [HttpPost]
        public async Task<ActionResult<Collaborateur>> PostCollaborateur(CollaborateurDTO collaborateurDTO)
        {
            var returnedCollaborateur = await _collaborateurService.AddCollaborateur(collaborateurDTO);
            return CreatedAtAction("GetCollaborateur", new { id = returnedCollaborateur.Id }, returnedCollaborateur);
        }



        // GET: api/Collaborateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> GetCollaborateur(int id)
        {
            var Collab = await _collaborateurService.GetCollaborateur(id);



            if (Collab == null)
            {
                return NotFound();
            }



            return Collab;
        }
        // PUT: api/Collaborateurs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCollaborateur(int id, CollaborateurDTO collaborateur)
        {
            //if (id != collaborateur.Id)
            //{
            //    return BadRequest();
            //}



            try
            {
                await _collaborateurService.UpdateCollaborateur(id, collaborateur);
            }
            catch
            {
                throw;
            }



            return NoContent();
        }
    }
}

