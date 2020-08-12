using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using hepsiSefBlog.Data.Entities;
using hepsiSefBlog.Service.Model.Request;
using hepsiSefBlog.Service.Model.Response;
using hepsiSefBlog.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hepsiSefBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeService _service;
        public RecipesController(RecipeService service)
        {
            _service = service;
        }
        //Get api/recipes/getall
        [HttpGet]
        public IActionResult GetAll()
        {
            /*ekstralar BadRequest ve NotFound*/
            var recipes = _service.GetAll();
            if (recipes == null)
            {
                return NotFound();
            }
            return Ok(recipes);
        }

        //get api/recipes/2
        [HttpGet("{id}")]
        public RecipeResponse GetById([FromRoute]int id)
        {
            /*ekstralar BadRequest ve NotFound*/
            return _service.Get(id);
        }
        [HttpGet]
        [Route("/Query")]
        public List<RecipeResponse> Query([FromBody]RecipeQueryRequest recipeQuery)
        {
            //listede 0 tarif varsa 404 gönderebilirsin.
            return _service.Query(recipeQuery);
        }
        [HttpPost]
        public IActionResult Add([FromBody]RecipeCreateRequest createRequest)
        {
            //formata göre badrequest
            return new ObjectResult(createRequest) { StatusCode = StatusCodes.Status201Created };
        }
        [HttpPut]
        public IActionResult Update([FromBody]RecipeUpdateRequest updateRequest)
        {

            return new ObjectResult(updateRequest) { StatusCode = StatusCodes.Status204NoContent };
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {

            return NoContent();
        }


    }
}