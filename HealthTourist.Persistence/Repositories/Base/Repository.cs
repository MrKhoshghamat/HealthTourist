using System.Data;
using System.Linq.Expressions;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Persistence;
using HealthTourist.Persistence.DatabaseContexts;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.Repositories.Base;

public partial class Repository<TEntity, TPrimaryKey> (DbContext context, IAppLogger<TEntity> logger) 
    : IRepository<TEntity, TPrimaryKey>
    where TEntity : BaseEntity<TPrimaryKey>
{
    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
    {
        try
        {
            return await context.Set<TEntity>().AsNoTracking().ToListAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await context.Set<TEntity>().Where(predicate).AsNoTracking().ToListAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IQueryable<TEntity>> GetAllAsQueryableAsync()
    {
        try
        {
            return await Task.FromResult(context.Set<TEntity>().AsQueryable());
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IQueryable<TEntity>> GetAllAsQueryableAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await Task.FromResult(context.Set<TEntity>().Where(predicate).AsQueryable());
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<TEntity> FindAsync(TPrimaryKey id)
    {
        try
        {
            return (await context.Set<TEntity>().FindAsync(id))!;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return (await context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync())!;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsExistAsync(TPrimaryKey id)
    {
        try
        {
            return await context.Set<TEntity>().AnyAsync(x => x.Id != null && x.Id.Equals(id));
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await context.Set<TEntity>().AnyAsync(predicate);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> CreateAsync(TEntity entity)
    {
        try
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> UpdateAsync(TEntity entity)
    {
        try
        {
            await Task.FromResult(context.Set<TEntity>().Update(entity));
            await Task.FromResult(context.Entry(entity).State = EntityState.Modified);
            await context.SaveChangesAsync();
            
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DeleteAsync(TEntity entity)
    {
        try
        {
            entity.IsDeleted = true;
            await UpdateAsync(entity);
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DeleteAsync(TPrimaryKey id)
    {
        try
        {
            var entity = await FindAsync(id);
            await DeleteAsync(entity);

            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DisableAsync(TEntity entity)
    {
        try
        {
            entity.IsDisabled = true;
            await UpdateAsync(entity);

            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DisableAsync(TPrimaryKey id)
    {
        try
        {
            var entity = await FindAsync(id);
            await DisableAsync(entity);

            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}

public partial class Repository<TEntity> (HealthTouristDbContext context, IAppLogger<TEntity> logger) 
    : IRepository<TEntity> where TEntity : class
{
    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
    {
        try
        {
            return await context.Set<TEntity>().AsNoTracking().ToListAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await context.Set<TEntity>().Where(predicate).AsNoTracking().ToListAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IQueryable<TEntity>> GetAllAsQueryableAsync()
    {
        try
        {
            return await Task.FromResult(context.Set<TEntity>().AsQueryable());
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<IQueryable<TEntity>> GetAllAsQueryableAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await Task.FromResult(context.Set<TEntity>().Where(predicate).AsQueryable());
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<TEntity> FindAsync(int id)
    {
        try
        {
            return (await context.Set<TEntity>().FindAsync(id))!;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return (await context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync())!;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            await context.Set<TEntity>().AnyAsync(predicate);

            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> CreateAsync(TEntity entity)
    {
        try
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> UpdateAsync(TEntity entity)
    {
        try
        {
            await Task.FromResult(context.Set<TEntity>().Update(entity));
            await Task.FromResult(context.Entry(entity).State = EntityState.Modified);
            await context.SaveChangesAsync();
            
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DeleteAsync(TEntity entity)
    {
        try
        {
            await Task.FromResult(context.Set<TEntity>().Remove(entity));
            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var entity = await FindAsync(id);
            await DeleteAsync(entity);

            return true;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}