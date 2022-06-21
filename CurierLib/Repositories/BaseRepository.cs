using CurierLib.Models;
using Microsoft.EntityFrameworkCore;
using Scrutor.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Repositories
{
     public class BaseRepository<T> : ISelfTransientLifetime where T : Entity 
    {

        protected readonly DatabaseContext _context;

        public DbSet<T> entities;

        public BaseRepository(DatabaseContext context)
        {
            entities = context.Set<T>();
            _context = context;
        }
        public virtual List<T> GetAllForRead()
        {
            return entities.AsNoTracking().ToList();
        }


        public virtual List<T> GetAll()
        {
            return entities.ToList();
        }

        public virtual T GetOne(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public virtual T Add(T model, bool isSave = true)
        {
            if (model != null)
            {
                entities.Add(model);
                if (isSave)
                {
                    Save();
                }
            }
            return model;
        }
        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual T Update(T model, bool isSave = true)
        {
            if (model != null)
            {
                _context.Entry(model).State=EntityState.Modified;
                if (isSave)
                {
                    Save();
                }
            }
            return model;
        }
        public virtual T Remove(T model, bool isSave = true)
        {
            if (model != null)
            {
                entities.Remove(model);
                if (isSave)
                {
                    Save();
                }
            }
            return model;
        }
    } 


}
