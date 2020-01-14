using Chinook.WebApi.Models;
using Chinook.WebApi.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.WebApi.Strategy
{
    public class UnitOfWorkEngine : IUnitOfWorkEngine
    {
        private readonly IEnumerable<IUnitOfWork> _unitOfWorks;

        public UnitOfWorkEngine(IEnumerable<IUnitOfWork> unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        public IUnitOfWork GetUnitOfWork(DataBaseSelector dataBaseSelector)
        {
            return _unitOfWorks.First(x => x.DataBaseSelector == dataBaseSelector);
        }
    }
}
