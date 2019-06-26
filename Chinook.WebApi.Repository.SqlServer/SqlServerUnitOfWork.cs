using System;
using System.Collections.Generic;
using System.Text;
using Chinook.WebApi.Models;

namespace Chinook.WebApi.Repository.SqlServer
{
    public class SqlServerUnitOfWork : IUnitOfWork
    {
        public DataBaseSelector DataBaseSelector { get ; set; }
        public SqlServerUnitOfWork(ChinookSqlContext context)
        {
            DataBaseSelector = DataBaseSelector.SqlServer;

            Album = new Repository<Album>(context);
        }

        public IRepository<Album> Album { get; private set; }

    }
}
