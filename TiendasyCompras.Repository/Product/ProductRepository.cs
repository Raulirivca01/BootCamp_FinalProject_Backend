
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TiendasyCompras.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }
        public async Task<int> Create(Model.Product product)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Name", product.Name);
            parameters.Add("@Description", product.Description);
            parameters.Add("@ProductTypeId", product.ProductTypeId);
            parameters.Add("@Brand", product.Brand);
            parameters.Add("@Price", product.Price);
            parameters.Add("@Stock", product.Stock);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_Product]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Del_Product]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Update(Model.Product product)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Id", product.Id);
            parameters.Add("@Name", product.Name);
            parameters.Add("@Description", product.Description);
            parameters.Add("@ProductTypeId", product.ProductTypeId);
            parameters.Add("@Brand", product.Brand);
            parameters.Add("@Price", product.Price);
            parameters.Add("@Stock", product.Stock);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Upd_Product]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
