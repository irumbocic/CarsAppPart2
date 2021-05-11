using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        //Task<int> CommitAsync();

        DbContext Db { get; }
        public Task<int> CommitAsync();
    }
}
