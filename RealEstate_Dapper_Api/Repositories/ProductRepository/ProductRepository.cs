using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            var parameter = new DynamicParameters();
            using (var conneciton = _context.CreateConnection())
            {
                var values = await conneciton.QueryAsync<ResultProductDto>(query);
                return values.ToList();

            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductsWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName from Product inner join Category on Product.ProductCategory=Category.CategoryID";
            var parameter = new DynamicParameters();
            using (var conneciton = _context.CreateConnection())
            {
                var values = await conneciton.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();

            }
        }
    }
}
