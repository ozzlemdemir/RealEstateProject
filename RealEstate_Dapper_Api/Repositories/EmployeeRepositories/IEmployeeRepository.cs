using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.EmployeeDros;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployee();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto  updateEmployeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
