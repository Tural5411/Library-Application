//using Kitabxana.Entities;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using Kitabxana.DataAccess.Interface;

namespace Kitabxana.Business.Servisler
{
    public interface IServisSablon<TEntity> where TEntity:class,IEntity,new()
    {
        List<TEntity> Listele(Expression<Func<TEntity, bool>> filtr = null);
        TEntity Getir(Expression<Func<TEntity, bool>> filtr);
        TEntity Elave(TEntity entity);
        TEntity Guncelle(TEntity entity);
        TEntity Sil(TEntity entity);
        TEntity AddOrUpdate(TEntity entity);
        bool QeydKontrol(Expression<Func<TEntity, bool>> filtr = null);
        void Save();
        BindingList<TEntity> Birlesdirme(Expression<Func<TEntity, bool>> filtr = null);
        DbContext ContextYarad(bool yeni = false);
        void ContextBagla(DbContext context);
        void Sil(Expression<Func<TEntity, bool>> filtr);
    }
}
