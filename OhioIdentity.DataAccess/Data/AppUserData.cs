using OhioIdentity.DataAccess.DbAccess;
using OhioIdentity.DataAccess.Models;

namespace OhioIdentity.DataAccess.Data;
public class AppUserData : IAppUserData
{
    #region Member Variables

    private readonly ISqlDataAccess db;

    #endregion Member Variables

    #region Constructors

    public AppUserData(ISqlDataAccess db)
    {
        this.db = db;
    }

    #endregion Constructors

    #region Public Methods

    public Task<IEnumerable<AppUserModel>> GetUsers() =>
        db.LoadData<AppUserModel, dynamic>(storedProcedure: "dbo.spAppUser_GetAll", new { });

    public async Task<AppUserModel?> GetUser(int id)
    {
        var results = await db.LoadData<AppUserModel, dynamic>(storedProcedure: "dbo.spAppUser_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertUser(AppUserModel user) =>
        db.SaveData(storedProcedure: "dbo.spAppUser_Insert", new { user.EmailAddress, user.FirstName, user.LastName, user.MiddleName });

    public Task UpdateUser(AppUserModel user) =>
        db.SaveData(storedProcedure: "dbo.spAppUser_Update", user);

    public Task DeleteUser(int id) =>
        db.SaveData(storedProcedure: "dbo.spAppUser_Delete", new { Id = id });

    #endregion Public Methods
}
