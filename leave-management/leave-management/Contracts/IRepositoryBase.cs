using System;
using System.Collections.Generic;


namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();

        T FindById(int Id);

        bool isExists(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}
