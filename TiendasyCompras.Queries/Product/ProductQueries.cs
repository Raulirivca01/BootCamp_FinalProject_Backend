using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using TiendasyCompras.ViewModel;

namespace TiendasyCompras.Queries.Product
{
    public class ProductQueries : IProductQueries
    {
        private readonly string _connectionString;

        public ProductQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<IEnumerable<ProductViewModel>> GetAll()
        {
            IEnumerable<ProductViewModel> result = new List<ProductViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductViewModel>("[dbo].[Usp_Sel_Product]", commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<ProductByIdViewModel> GetById(int id)
        {
            var productByIdViewModel = new ProductByIdViewModel();

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                productByIdViewModel = await connection.QueryFirstOrDefaultAsync<ProductByIdViewModel>("[dbo].[Usp_Sel_Product_ById]", parameters, commandType: CommandType.StoredProcedure);
            }

            return productByIdViewModel;
        }
    }
}
