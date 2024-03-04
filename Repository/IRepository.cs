﻿using System.Collections.Generic;

namespace AccommodationManagerApp.Repository {
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}