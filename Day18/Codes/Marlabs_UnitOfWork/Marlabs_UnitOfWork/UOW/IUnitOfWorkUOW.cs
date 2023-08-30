using Marlabs_UnitOfWork.Repository;
namespace Marlabs_UnitOfWork.UOW
{
    public interface IUnitOfWorkUOW
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }

        int Complete();
        void Dispose();
    }
}
