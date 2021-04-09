using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        public bool Create(T item);
        public bool Delete(int id);
        public T GetById(int id);
        public bool Update(T item);


    }
}