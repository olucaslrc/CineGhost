using System;
using CineGhost.Domain.Interfaces;

namespace CineGhost.Infra.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly EFContext _dbContext;

    public UnitOfWork(EFContext dbContext)
    {
        _dbContext = dbContext;
    }

    // public IAsyncRepository() where T : BaseEntity
    // {
        
    // }
}