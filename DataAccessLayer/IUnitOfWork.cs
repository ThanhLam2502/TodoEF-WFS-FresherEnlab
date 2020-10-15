using System;
using DataAccessLayer.Entity;
using DataAccessLayer.Repository;


namespace DataAccessLayer
{
    public interface IUnitOfWork: IDisposable
    {
        ITodoRepository TodoRepository { get; }
        int Complete();
    }
}
