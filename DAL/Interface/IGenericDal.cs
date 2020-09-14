using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digiturk.ArticleApi.DAL.Interface
{
	 public interface IGenericDal<T> where T : class, new()
	{
		T Add(T entity);
		T Delete(int id);
		T Update(T entity);
		T Get(int id);
		List<T> GetAll();
		
	}
	
}
