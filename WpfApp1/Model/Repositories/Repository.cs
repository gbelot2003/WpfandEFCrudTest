using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Repositories
{
    class Repository<T> where T : class
    {
        private WpdApp1Entity context = new WpdApp1Entity();

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            DbSet = context.Set<T>();
           
        }

        public List<T> GetList()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void add(T entity)
        {
            DbSet.Add(entity);
        }

        public void remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}