using TiendasyCompras.ViewModel;

namespace TiendasyCompras.Queries.Product
{
    public interface IProductQueries
    {
        Task<ProductByIdViewModel> GetById(int id);
        Task<IEnumerable<ProductViewModel>> GetAll();
    }
}
