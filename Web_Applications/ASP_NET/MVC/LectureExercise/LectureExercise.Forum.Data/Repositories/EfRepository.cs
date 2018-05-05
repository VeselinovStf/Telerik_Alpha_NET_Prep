using LectureExercise.Forum.Data.Model.Contracts;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace LectureExercise.Forum.Data.Repositories
{
    public class EfRepository<T> : IEfRepository<T>
        where T : class, IDeletable
    {
        private readonly MsSqlDbContext content;

        public EfRepository(MsSqlDbContext content)
        {
            this.content = content;
        }

        public IQueryable<T> All
        {
            get
            {
                return this.content.Set<T>().Where(x => !x.IsDeleted);
            }
        }

        public IQueryable<T> AllAndDeleted
        {
            get
            {
                return this.content.Set<T>();
            }
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.content.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.content.Set<T>().Add(entity);
            }
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;

            var entry = this.content.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.content.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.content.Set<T>().Attach(entity);
            }
            else
            {
                entry.State = EntityState.Modified;
            }
        }
    }
}
