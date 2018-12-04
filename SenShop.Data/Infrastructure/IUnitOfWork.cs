namespace SenShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}