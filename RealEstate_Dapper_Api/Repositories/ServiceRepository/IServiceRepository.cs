using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto categoryDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto categoryDto);
        Task<GetByIDServiceDto> GetCategory(int id);
    }
}
