using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digiturk.ArticleApi.Entities
{
	public class Article
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime CreationDate { get; set; }

		public int AuthorId { get; set; }
		public Author Author { get; set; }

	}
}
