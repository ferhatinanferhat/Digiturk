using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Digiturk.ArticleApi.DAL.Concrete.EntityFrameworkCore.Repository;
using Digiturk.ArticleApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digiturk.ArticleApi.Controllers.Concrete
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArticleController : ControllerBase
	{
		private readonly EFArticleRepository efArticleRepository;
		public ArticleController()
		{
			efArticleRepository = new EFArticleRepository();
		}


		[HttpGet]
		public IActionResult Get()
		{
			var model = efArticleRepository.GetAll();
			return Ok(model);

		}

		[HttpGet("{id}")]

		public IActionResult Get(int id)
		{
			var model = efArticleRepository.Get(id);
			return Ok(model);

		}

		[HttpPut]
		public IActionResult Put(Article entity)
		{
			var model = efArticleRepository.Update(entity);

			return NoContent();

		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var model = efArticleRepository.Delete(id);
			return NoContent();

		}

		[HttpPost]
		public IActionResult Post(Article entity)
		{
			var model = efArticleRepository.Add(entity);
			return Created("", model);

		}


	}
}