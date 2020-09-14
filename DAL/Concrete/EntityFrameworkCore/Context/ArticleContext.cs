using Digiturk.ArticleApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digiturk.ArticleApi.DAL.Concrete.Context
{
	public class ArticleContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RDA326M; Database=DigiturkArticle; Integrated Security=true;");
		}

		public DbSet<Article> Articles { get; set; }
		public DbSet<Author> Authors { get; set; }
	}
}
