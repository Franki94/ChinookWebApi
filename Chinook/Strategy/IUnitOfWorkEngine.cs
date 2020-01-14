using Chinook.WebApi.Models;
using Chinook.WebApi.Repository;

namespace Chinook.WebApi.Strategy
{
    public interface IUnitOfWorkEngine
    {
        IUnitOfWork GetUnitOfWork(DataBaseSelector dataBaseSelector);
    }
}
