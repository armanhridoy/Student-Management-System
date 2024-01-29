﻿using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;

namespace StudentManagementSystem.Service;

public interface ICommonService<TEntity, IModel>
    where TEntity : class, new() where IModel : class
{
    Task<IEnumerable<IModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<IModel> InsertAsync(IModel model, CancellationToken cancellationToken);
    Task<IModel> UpDateAsync(int Id, IModel model, CancellationToken cancellationToken);
    Task<IModel> DeleteAsync(int Id, CancellationToken cancellationToken);
    Task<IModel> GetByIdAsync(int Id, CancellationToken cancellationToken);
    public Task<List<IModel>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);
}
