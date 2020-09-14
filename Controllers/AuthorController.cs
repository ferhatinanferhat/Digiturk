using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Digiturk.ArticleApi.DAL.Concrete.EntityFrameworkCore.Repository;
using Digiturk.ArticleApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digiturk.ArticleApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		private readonly EFAuthorRepository efAuthorRepository;
		public AuthorController()
		{
			efAuthorRepository = new EFAuthorRepository();
		}

		[HttpGet]
		public IActionResult Get()
		{
			var model = efAuthorRepository.GetAll();
			return Ok(model);
			
		}

		[HttpGet("{id}")]

		public IActionResult Get(int id)
		{
			var model = efAuthorRepository.Get(id);
			return Ok(model);
			
		}

		[HttpPut]
		public IActionResult Put(Author entity)
		{
			var model=efAuthorRepository.Update(entity);
			
				return NoContent();
			
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var model= efAuthorRepository.Delete(id);
			return NoContent();
			
		}

		[HttpPost]
		public IActionResult Post(Author entity)
		{
		var model = efAuthorRepository.Add(entity);
		return Created("",model);
		
	}

		

	}
}