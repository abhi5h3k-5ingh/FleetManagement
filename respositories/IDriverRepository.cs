using fleetmanagement.entities;

namespace fleetmanagement.repositories;

public interface IDriverRepository
{
    Task<IEnumerable<Driver>> GetAllDriversAsync();
    Task<Driver?> GetDriverByIdAsync(int id);
    Task<Driver> AddDriverAsync(Driver driver);
    Task<Driver?> UpdateDriverAsync(Driver driver);
    Task<bool> DeleteDriverAsync(int id);
}
