using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data.Repositories
{
    public interface ITransactionalRepository
    {
        Task<bool> BeginTransaction();

        Task<bool> CommitTransaction();

        Task<bool> RollbackTransaction();

        bool EndTransaction();

    }
}
