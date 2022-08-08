using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data.Repositories
{
    public interface ICrudRepository:ITransactionalRepository
    {
        Task<TDto> Create<TEntity, TDto>(TDto dto) where TEntity : class;

        Task<IEnumerable<TDto>> Create<TEntity, TDto>(List<TDto> dto) where TEntity : class;

        Task<TDto> Find<TEntity, TDto>(string name) where TEntity : class;

        Task<IEnumerable<TDto>> GetAll<TEntity, TDto>() where TEntity : class;

        Task<TDto> Update<TEntity, TDto>(TDto dto) where TEntity : class;

        Task<List<TDto>> Update<TEntity, TDto>(List<TDto> dtos) where TEntity : class;

        Task<TDto> Delete<TEntity, TDto>(TDto dto) where TEntity : class;

    }
}
