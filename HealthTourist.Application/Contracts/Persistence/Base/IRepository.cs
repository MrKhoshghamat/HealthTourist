using System.Linq.Expressions;
using HealthTourist.Domain.Persistence;

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
    Task<bool> CreateAsync(TEntity entity);
    Task<bool> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> DeleteAsync(TPrimaryKey id);

    #endregion
}

public partial interface IRepository<TEntity> where TEntity : class
{
    #region Asyncronous

    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync();
    Task<IQueryable<TEntity>> GetAllAsQueryableAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> FindAsync(int id);
    Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<bool> IsExistAsync(int id);
    Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task<bool> CreateAsync(TEntity entity);
    Task<bool> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> DeleteAsync(int id);

    #endregion
}