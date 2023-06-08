using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace OhioIdentity.DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    #region Member Variables

    private readonly IConfiguration configuration;

    #endregion Member Variables

    #region Constructors

    public SqlDataAccess(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    #endregion Constructors

    #region Public Methods

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionId));
        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionId));
        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    #endregion Public Methods
}
