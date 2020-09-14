using Digiturk.ArticleApi.DAL.Concrete.Context;
using Digiturk.ArticleApi.DAL.Interface;
using Digiturk.ArticleApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digiturk.ArticleApi.DAL.Concrete.EntityFrameworkCore.Repository
{
	public class EFGenericRepository<T> : IGenericDal<T> where T : class, new()

	{
		public T Add(T entity)
		{
			using (var context = new ArticleContext())
			{
				context.Set<T>().Add(entity);
				context.SaveChanges();
			}
			return entity;
		}

		public T Delete(int id)
		{
			using (var context = new ArticleContext())
			{
				var entityDelete= context.Set<T>().Find(id);
				if (entityDelete == null)
				{
					return entityDelete;
				}
				context.Set<T>().Remove(entityDelete);
				context.SaveChanges();
				return entityDelete;
			}

			
		}

		public T Get(int id)
		{
			using (var context = new ArticleContext())
			{
				return context.Set<T>().Find(id);
				
			}
		}

		public List<T> GetAll()
		{
			using (var context = new ArticleContext())
			{
				return context.Set<T>().ToList();

			}
		}

		public T Update(T entity)
		{

			using (var context = new ArticleContext())
			{

				context.Set<T>().Update(entity);
				context.SaveChanges();
			}
			return entity;
		}
	}
}
