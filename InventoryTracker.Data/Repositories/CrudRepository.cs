using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data.Repositories
{
    public class CrudRepository : ICrudRepository
    {
        Task<bool> ITransactionalRepository.BeginTransaction()
        {
            throw new NotImplementedException();
        }

        Task<bool> ITransactionalRepository.CommitTransaction()
        {
            throw new NotImplementedException();
        }

        Task<TDto> ICrudRepository.Create<TEntity, TDto>(TDto dto)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TDto>> ICrudRepository.Create<TEntity, TDto>(List<TDto> dto)
        {
            throw new NotImplementedException();
        }

        Task<TDto> ICrudRepository.Delete<TEntity, TDto>(TDto dto)
        {
            throw new NotImplementedException();
        }

        bool ITransactionalRepository.EndTransaction()
        {
            throw new NotImplementedException();
        }

        Task<TDto> ICrudRepository.Find<TEntity, TDto>(string name)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TDto>> ICrudRepository.GetAll<TEntity, TDto>()
        {
            throw new NotImplementedException();
        }

        Task<bool> ITransactionalRepository.RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        Task<TDto> ICrudRepository.Update<TEntity, TDto>(TDto dto)
        {
            throw new NotImplementedException();
        }

        Task<List<TDto>> ICrudRepository.Update<TEntity, TDto>(List<TDto> dtos)
        {
            throw new NotImplementedException();
        }
    }
}
