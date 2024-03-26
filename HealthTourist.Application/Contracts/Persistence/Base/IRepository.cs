using System.Linq.Expressions;
using HealthTourist.Domain;

namespace HealthTourist.Application.Contracts.Persistence.Base;

public partial interface IRepository<TEntity, in TPrimaryKey> where TEntity : BaseEntity<TPrimaryKey>
{
    #region Asyncronous

    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync();
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> FindAsync(TPrimaryKey id);
    Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<bool> IsExistAsync(TPrimaryKey id);
    Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task DeleteAsync(TPrimaryKey id);
    Task DisableAsync(TEntity entity);
    Task DisableAsync(TPrimaryKey id);

    #endregion
}

public partial interface IRepository<TEntity>
{
    #region Asyncronous

    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync();
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> FindAsync(int id);
    Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task DeleteAsync(int id);

    #endregion
}