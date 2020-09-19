using FluentValidation;
using Kitabxana.Business.Servisler;
using Kitabxana.Business.Vasiteler;
using Kitabxana.DataAccess.Interface;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Idare
{
    public class IdareSablonu<TEntity,TDal,TValidator> : IServisSablon<TEntity>
        where TEntity : class, IEntity, new()
        where TDal : class, IEntitySablon<TEntity>,new()
        where TValidator:IValidator,new()
    {
        protected TDal _dal = new TDal();
        TesdiqVasitesi tesdiqlemeVasitesi = new TesdiqVasitesi();
        TValidator tesdiqleme = new TValidator();

        public TEntity AddOrUpdate(TEntity entity)//
        {
            if (tesdiqlemeVasitesi.Tesdiqle(tesdiqleme, entity))
            {
                return _dal.AddOrUpdate(entity);
            }
            else
            {
                return null;
            }
        }

      
        public BindingList<TEntity> Birlesdirme(Expression<Func<TEntity, bool>> filtr = null)
        {
            return _dal.Birlesdirme(filtr);
        }

        public void ContextBagla(DbContext context)
        {
            _dal.ContextBagla(context);
        }

        public DbContext ContextYarad(bool yeni = false)
        {
            return _dal.ContextYarad(yeni);
        }

        public TEntity Elave(TEntity entity)//
        {
            if (tesdiqlemeVasitesi.Tesdiqle(tesdiqleme, entity))
            {
                return _dal.Elave(entity);
            }
            else
            {
                return null;
            }
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtr)
        {
            return _dal.Getir(filtr);
        }

        public TEntity Guncelle(TEntity entity)//
        {
            if (tesdiqlemeVasitesi.Tesdiqle(tesdiqleme, entity))
            {
                return _dal.Guncelle(entity);
            }
            else
            {
                return null;
            }
        }

        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtr = null)
        {
            return _dal.Listele(filtr);
        }

        public bool QeydKontrol(Expression<Func<TEntity, bool>> filtr = null)
        {
            return _dal.QeydKontrol(filtr);
        }

        public void Save()
        {
            _dal.Save();
        }
        //Virtual daha sonra deyisiklik etmek ucun lazimdir. sonra override edirsen!
        public virtual TEntity Sil(TEntity entity)
        {
            //if (tesdiqlemeVasitesi.Tesdiqle(tesdiqleme, entity))
            //{
                return _dal.Sil(entity);
            //}
            //else
            //{
            //    return null;
            //}
        }

        public void Sil(Expression<Func<TEntity, bool>> filtr)
        {
            _dal.Sil(filtr);
        }
    }
}
