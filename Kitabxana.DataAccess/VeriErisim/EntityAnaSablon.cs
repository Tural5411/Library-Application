using Kitabxana.DataAccess.Contexts;
using Kitabxana.DataAccess.Interface;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.DataAccess.VeriErisim
{
    public class EntityAnaSablon<TEntity, TContext> : IEntitySablon<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected TContext _context;
        public TEntity AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            return entity;
        }

        public TEntity Elave(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            return entity;
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtr)
        {
            return _context.Set<TEntity>().SingleOrDefault(filtr);
        }

        public TEntity Guncelle(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }
        public TEntity Sil(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            return entity;
        }

        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtr = null)
        {
            return filtr == null ? _context.Set<TEntity>().ToList()
                                 : _context.Set<TEntity>().Where(filtr).ToList();
        }

        public void Sil(Expression<Func<TEntity, bool>> filtr)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filtr));
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public DbContext ContextYarad(bool yeni = false)
        {
            return yeni == true
                ? _context = new TContext()
                : _context;
        }


        public void ContextBagla(DbContext context)
        {
            _context = (TContext)context;
        }

        public BindingList<TEntity> Birlesdirme(Expression<Func<TEntity, bool>> filtr = null)
        {
            if (filtr == null)
            {
                _context.Set<TEntity>().Load();
            }
            else
            {
                _context.Set<TEntity>().Where(filtr).Load();
            }
            return _context.Set<TEntity>().Local.ToBindingList();
        }

        public bool QeydKontrol(Expression<Func<TEntity, bool>> filtr = null)
        {
            return _context.Set<TEntity>().Any(filtr);
        }
    }
}
