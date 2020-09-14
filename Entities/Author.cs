using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digiturk.ArticleApi.Entities
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string Telefon { get; set; }
		public string Email { get; set; }

		public List<Article> Articles { get; set; }
	}
}
