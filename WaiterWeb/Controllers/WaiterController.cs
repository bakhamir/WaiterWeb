using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using WaiterWeb.Models;
namespace WaiterWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaiterController : ControllerBase
    {
        [HttpPost("/LoginWaiter")]
        public async Task<string> LoginWaiter(int id)
        {
            string conStr = @"Data Source=207-3;Initial Catalog=WaiterDb;Integrated Security=True;TrustServerCertificate=Yes";
            try
            {
                using (var db = new SqlConnection(conStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@id", id);
                    string res = db.ExecuteScalar("pWaiter",p, commandType: System.Data.CommandType.StoredProcedure).ToString();
                    return res;    
                }
            }
            catch (Exception ex)
            {
                return "Error broken id or smth";
            }
        }
        [HttpPost("/GetTables")]
        public async Task<IEnumerable<diningtable>> GetTables(int id)
        {
            string conStr = @"Data Source=207-3;Initial Catalog=WaiterDb;Integrated Security=True;TrustServerCertificate=Yes";
            try
            {
                using (var db = new SqlConnection(conStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@id", id);
                    var res = db.Query<diningtable>("pTable",p, commandType: System.Data.CommandType.StoredProcedure);
                    return res;    
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }










    }
}
