using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurRepository
    {
        Task<IEnumerable<CollaboraterDTO>> GetCollaboraters();
        Task<IEnumerable<CollaboraterDTO>> GetCollaborator(int id);
        Task UpdateCollaborator(int id, CollaboraterDTO collaborator);
        Task<CollaboraterDTO> AddCollaborator(CollaboraterDTO collaborator);
        Task DeleteCollaborator(int id);
        bool CollaboratorExists(int id);
    }
}
