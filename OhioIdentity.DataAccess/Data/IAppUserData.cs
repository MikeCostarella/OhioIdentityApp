using OhioIdentity.DataAccess.Models;

namespace OhioIdentity.DataAccess.Data;
public interface IAppUserData
{
    Task DeleteUser(int id);
    Task<AppUserModel?> GetUser(int id);
    Task<IEnumerable<AppUserModel>> GetUsers();
    Task InsertUser(AppUserModel user);
    Task UpdateUser(AppUserModel user);
}