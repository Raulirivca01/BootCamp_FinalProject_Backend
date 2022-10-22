namespace TiendasyCompras.Repository.Product
{
    public interface IProductRepository
    {
        Task<int> Create(Model.Product product);

        Task<int> Update(Model.Product product);

        Task<int> Delete(int id);
    }
}
