using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        public IGenericRepository<T> Entity => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
