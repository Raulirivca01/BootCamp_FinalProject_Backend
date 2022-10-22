using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using TiendasyComprasViewModel.ViewModel;

namespace TiendasyComprasViewModel.Queries.ProductType
{

    public class ProductTypeQueries : IProductTypeQueries
    {
        private readonly string _connectionString;
        public ProductTypeQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<ProductTypeViewModel>> GetAll()
        {
            IEnumerable<ProductTypeViewModel> result = new List<ProductTypeViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductTypeViewModel>("[dbo].[Usp_Sel_ProductType]", commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
