using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CollaborateurRepository : ICollaborateurRepository
    {
        private readonly DataContext _dataContext;



        public CollaborateurRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }



        public async Task<IEnumerable<Collaborateur>> GetCollaborateurs()
        {



            return await _dataContext.Collaborators.ToListAsync();
        }



        public async Task<Collaborateur> AddCollaborateur(Collaborateur collaborateur)
        {
            _dataContext.Collaborators.Add(collaborateur);
            await _dataContext.SaveChangesAsync();
            return collaborateur;
        }



        public bool CollaborateurExists(int id)
        {
            throw new NotImplementedException();
        }



        public Task DeleteCollaborateur(int id)
        {
            throw new NotImplementedException();
        }



        public async Task<Collaborateur> GetCollaborateur(int id)
        {
            var collab = await _dataContext.Collaborators.FindAsync(id);
            return collab;
        }

        public async Task UpdateCollaborateur(int id, Collaborateur collaborateur)
        {
            if (id == collaborateur.Id)
            {
                _dataContext.Entry(collaborateur).State = EntityState.Modified;
                try
                {
                    await _dataContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
        }
    }
}
