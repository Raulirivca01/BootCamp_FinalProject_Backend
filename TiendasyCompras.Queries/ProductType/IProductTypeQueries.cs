using TiendasyComprasViewModel.ViewModel;

namespace TiendasyComprasViewModel.Queries.ProductType
{
    public interface IProductTypeQueries
    {
        Task<IEnumerable<ProductTypeViewModel>> GetAll();
    }
}


