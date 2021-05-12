using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehicleContext context;

        public UnitOfWork(VehicleContext context) // U Unit of work moram staviti samo slucaj kad se kreira novi model, koji nema make iz liste (nego se kreira i novi make)... uh... razmisliti dobro o ovome
        {
            this.context = context;
        }

        public DbContext Db
        {
            get { return context; }
        }

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();

        }

        public void Dispose() // OVAJ DISPOSE SREDITI!!! -Pogledaj primjer iz uputa!!!
        {
        }
    }
}
