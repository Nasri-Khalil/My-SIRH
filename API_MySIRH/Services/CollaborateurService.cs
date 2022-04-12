using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CollaborateurService : ICollaborateurService 
    {
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;



        public CollaborateurService(IMapper mapper, ICollaborateurRepository collaborateurRepository)
        {
            this._mapper = mapper;
            this._collaborateurRepository = collaborateurRepository;
        }
        public async Task<CollaborateurDTO> AddCollaborateur(CollaborateurDTO collaborateur)
        {
            var returnedCollaborateur = await _collaborateurRepository.AddCollaborateur(_mapper.Map<Collaborateur>(collaborateur));
            return _mapper.Map<CollaborateurDTO>(returnedCollaborateur);
        }

        public Task DeleteCollaboratur(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurDTO> GetCollaborateur(int id)
        {
            var result = await _collaborateurRepository.GetCollaborateur(id);
            return _mapper.Map<CollaborateurDTO>(result);
        }

        public async Task<IEnumerable<CollaborateurDTO>> GetCollaborateurs()
        {
            var result = await _collaborateurRepository.GetCollaborateurs();
            return _mapper.Map<IEnumerable<Collaborateur>, IEnumerable<CollaborateurDTO>>(result);
        }

        public async Task UpdateCollaborateur(int id, CollaborateurDTO collaborateur)
        {
            var collab = _mapper.Map<Collaborateur>(collaborateur);
            await _collaborateurRepository.UpdateCollaborateur(id, collab);
        }
    }
}
